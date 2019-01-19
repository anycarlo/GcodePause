using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace GcodeDivider
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        String filePath = @"Z:\test.gcode";
        String[] lines;

        List<int> layers_rows_idx;
        int end_gcode_row = 0;

        List<int> cutLevel;
        int nLayers = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void countLines()
        {
            foreach (string l in lines)
            {
                if (l.Contains("LAYER_COUNT"))
                {
                    string[] tmp = l.Split(new char[] { ':' });
                    int.TryParse(tmp[1], out int nLayers);
                    return;
                }
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            CutList.Items.Add(new itCut((int)numCut.Value));
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int selection = CutList.SelectedIndex;
            if (selection > -1)
            {
                CutList.Items.RemoveAt(selection);
            }
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            filePath = txtPath.Text;
            findLayersidx();

            cutLevel = new List<int>();
            cutLevel.Add(0); //add range 0-->cut1
            foreach (var i in CutList.Items)
            {
                cutLevel.Add(((itCut)i).layer); //add range cut i-1 --> cut i
            }
            cutLevel.Add(-1); //add range cut -i --> end
        
            

            int cc = 0;

            String lastE = "";
            string prevEndZValue = "0";
            for (int i = 1; i < cutLevel.Count; i++)
            {
                
                List<String> tmp = new List<string>();
                //append common initial gcode (line0 --> "LAYER:0"
                tmp.AddRange(appendLines(0, GetLayerRowOf(0)));

                //append central gcode of current slice
                int startLayer = GetLayerRowOf(cutLevel[i - 1]);
                int endLayer = GetLayerRowOf(cutLevel[i]);
                tmp.AddRange(appendLines(startLayer, endLayer));

                //add custom gcode at the end of this layer
                tmp.AddRange(getTextBoxLines());

                //append common final part
                tmp.AddRange(appendLines(end_gcode_row, lines.Length));

                //replace in prefix gcode the initial value for motor E
                if (rbABS.Checked)
                {
                    string startEvalue = findFirst_G1_E(startLayer);
                    int toReplace = findLast_G92_E0_backwards(GetLayerRowOf(0));
                    tmp[toReplace] = "G92 E" + startEvalue;
                }

                int searchStart = findLast_G28_backwards(GetLayerRowOf(0));
                int startZrow = idxFindFirst_G1_Z(searchStart);
                String row = lines[startZrow];
                String[] tmp2 = row.Split(new char[] { ' ', '\t' });
                for (int k = 0; k < tmp2.Length; k++)
                {
                    if (tmp2[k].StartsWith("Z"))
                    {
                        String str = tmp2[k].Replace("Z", "");
                        float defvalue = 0;
                        float.TryParse(str, out defvalue);

                        float curvalue = 0;
                        float.TryParse(prevEndZValue, out curvalue);

                        float value = curvalue + defvalue;

                        tmp2[k] = "Z" + value.ToString("0.00");
                    }
                }

                tmp[startZrow] = String.Join(" ", tmp2);

                if (i < cutLevel.Count - 1)
                    prevEndZValue = findFirst_G1_Z(endLayer);




                //String outputPath = @"Z:\slice" + i + ".gcode";
                String outputPath = Path.GetDirectoryName( filePath);
                String outputName = Path.GetFileNameWithoutExtension(filePath);
                outputName = outputName + "_slice_" + i + ".gcode";
                outputPath = Path.Combine(outputPath, outputName);


                File.WriteAllLines(outputPath, tmp.ToArray());
            }

            //add final cut, from last cut point to end of gcode
            String folder = Path.GetDirectoryName(filePath);
            System.Diagnostics.Process.Start(folder);
        }

        private string findFirst_G1_E(int fromLine)
        {
            String toret = "";
            bool trovato = false;
            int c = 0;
            while (!trovato)
            {
                string s = lines[fromLine + c];
                if ((s.StartsWith("G1") || s.StartsWith("G0")) && s.Contains("E"))
                {
                    string[] tmp = s.Split(new char[] { 'E' });
                    string valueE = tmp[1];
                    return valueE;
                }
                c++;
            }
            return toret;
        }


            private string findFirst_G1_Z(int fromLine)
        {
            String toret = "";
            bool trovato = false;
            int c = 0;
            while (!trovato)
            {
                string s = lines[fromLine + c];
                if ((s.StartsWith("G1") || s.StartsWith("G0")) && s.Contains("Z"))
                {
                    string[] tmp = s.Split(new char[] { 'Z' });
                    string[] tmp2 = tmp[1].Split(new char[] { ' ', '\t' });
                    string valueZ = tmp2[0];
                    return valueZ;
                }
                c++;
            }
            return toret;
        }

        private int idxFindFirst_G1_Z(int fromLine)
        {
            String toret = "";
            bool trovato = false;
            int c = 0;
            while (!trovato)
            {
                string s = lines[fromLine + c];
                if ((s.StartsWith("G1") || s.StartsWith("G0")) && s.Contains("Z"))
                {
                    string[] tmp = s.Split(new char[] { 'Z' });
                    string[] tmp2 = tmp[1].Split(new char[] { ' ', '\t' });
                    string valueZ = tmp2[0];
                    return (fromLine + c);
                }
                c++;
            }
            return 0;
        }

        private int findLast_G92_E0_backwards(int fromline)
        {
            String toret = "";
            bool trovato = false;
            int c = 0;
            while (!trovato)
            {
                string s = lines[fromline + c ];
                if (s.StartsWith("G92") && s.Contains("E0"))
                {
                    return fromline + c;
                }
                c--;
            }
            return -1;
        }

        private int findLast_G28_backwards(int fromline)
        {
            String toret = "";
            bool trovato = false;
            int c = 0;
            while (!trovato)
            {
                string s = lines[fromline + c];
                if (s.StartsWith("G28"))
                {
                    return fromline + c;
                }
                c--;
            }
            return -1;
        }

        private int GetLayerRowOf(int idx)
        {
            if (idx >= 0)
                return layers_rows_idx[idx];
            else
                return end_gcode_row;
        }

        private List<String> appendLines(int start, int end)
        {
            List<string> toret = new List<string>();
            for (int k = start; k < end; k++)
            {
                toret.Add(lines[k]);
            }

            return toret;
        }

        private void findLayersidx()
        {
            layers_rows_idx = new List<int>();
            for (int k = 0; k < lines.Length; k++)
            {
                if (lines[k].Contains(";LAYER:"))
                {
                    string[] tmp = lines[k].Split(new char[] { ':' });
                    int.TryParse(tmp[1], out int nLayers);
                    layers_rows_idx.Add(k);
                }

                if (lines[k].Contains(";End of Gcode"))
                {
                    end_gcode_row = k;
                }

            }



            int a = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CutList.Items.Count < 1)
                btnGen.Enabled = false;
            else
                btnGen.Enabled = true;

            if (File.Exists(txtPath.Text))
            {
                
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            note fr = new note();

            if (!File.Exists("nostartup.txt"))
            {
                fr.ShowDialog();
            }

            if (fr.boxCheck == true)
            {
                try
                {
                    File.Create("nostartup.txt");
                }
                catch (Exception ex)
                {
                    ;
                }
            }


            txtGcode.Text = "G91 ;relative coordinates \r\n";
            txtGcode.AppendText("G1 Z5; lift nozzle 5mm\r\n");
            txtGcode.AppendText("G90 ;absolute coordinates\r\n");
            txtGcode.AppendText("G0 X0 Y0 ;go to home\r\n");
        }

        private List<string> getTextBoxLines()
        {
            List<string> txtLines = new List<string>();
            string mytext = txtGcode.Text;
            foreach (var myString in mytext.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
            {
                txtLines.Add(myString);
            }
            return txtLines;

        }

        private void btnNotes_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSelectFile_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            DialogResult res = of.ShowDialog();
            if (res == DialogResult.OK || res == DialogResult.Yes)
            {
                String path = of.FileName;
                txtPath.Text = path;
                filePath = path;

                lines = File.ReadAllLines(filePath);
                findLayersidx();

                txtShowFile.Text = "";
                txtShowFile.AppendText("File: " + path +Environment.NewLine);
                txtShowFile.AppendText(Environment.NewLine);
                txtShowFile.AppendText("Lines: " + lines.Length + Environment.NewLine);
                txtShowFile.AppendText("Layers: " + layers_rows_idx.Count + Environment.NewLine);

                numCut.Maximum = layers_rows_idx.Count;

                txtShowFile.Visible = true;

            }
        }

        private void rbREL_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
