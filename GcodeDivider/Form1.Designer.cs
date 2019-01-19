namespace GcodeDivider
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtShowFile = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbABS = new System.Windows.Forms.RadioButton();
            this.rbREL = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGcode = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.numCut = new System.Windows.Forms.NumericUpDown();
            this.CutList = new System.Windows.Forms.ListBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnGen = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCut)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtShowFile
            // 
            this.txtShowFile.Enabled = false;
            this.txtShowFile.Location = new System.Drawing.Point(999, 22);
            this.txtShowFile.Margin = new System.Windows.Forms.Padding(2);
            this.txtShowFile.Multiline = true;
            this.txtShowFile.Name = "txtShowFile";
            this.txtShowFile.Size = new System.Drawing.Size(443, 182);
            this.txtShowFile.TabIndex = 13;
            this.txtShowFile.Text = "Gcode data...";
            this.txtShowFile.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox7);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Location = new System.Drawing.Point(665, 229);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(7);
            this.groupBox3.Size = new System.Drawing.Size(810, 770);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Options";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Controls.Add(this.label2);
            this.groupBox7.Controls.Add(this.numericUpDown2);
            this.groupBox7.Controls.Add(this.label1);
            this.groupBox7.Controls.Add(this.numericUpDown1);
            this.groupBox7.Location = new System.Drawing.Point(121, 467);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(656, 293);
            this.groupBox7.TabIndex = 15;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "While paused";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(623, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "OPTIONS NOT YET AVAILABLE, WORK IN PROGRESS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(21, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bed temp while paused";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Enabled = false;
            this.numericUpDown2.Location = new System.Drawing.Point(323, 166);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 35);
            this.numericUpDown2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(21, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nozzle temp while paused";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Location = new System.Drawing.Point(323, 125);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 35);
            this.numericUpDown1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbABS);
            this.groupBox2.Controls.Add(this.rbREL);
            this.groupBox2.Location = new System.Drawing.Point(121, 25);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(749, 132);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Extrusion Mode";
            // 
            // rbABS
            // 
            this.rbABS.AutoSize = true;
            this.rbABS.Location = new System.Drawing.Point(7, 74);
            this.rbABS.Margin = new System.Windows.Forms.Padding(2);
            this.rbABS.Name = "rbABS";
            this.rbABS.Size = new System.Drawing.Size(282, 33);
            this.rbABS.TabIndex = 1;
            this.rbABS.TabStop = true;
            this.rbABS.Text = "absolute (Gcode M82)";
            this.rbABS.UseVisualStyleBackColor = true;
            // 
            // rbREL
            // 
            this.rbREL.AutoSize = true;
            this.rbREL.Checked = true;
            this.rbREL.Location = new System.Drawing.Point(7, 33);
            this.rbREL.Margin = new System.Windows.Forms.Padding(2);
            this.rbREL.Name = "rbREL";
            this.rbREL.Size = new System.Drawing.Size(268, 33);
            this.rbREL.TabIndex = 0;
            this.rbREL.TabStop = true;
            this.rbREL.Text = "relative (Gcode M83)";
            this.rbREL.UseVisualStyleBackColor = true;
            this.rbREL.CheckedChanged += new System.EventHandler(this.rbREL_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtGcode);
            this.groupBox1.Location = new System.Drawing.Point(121, 161);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(679, 301);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gcode at end of each interval";
            // 
            // txtGcode
            // 
            this.txtGcode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGcode.Location = new System.Drawing.Point(17, 32);
            this.txtGcode.Margin = new System.Windows.Forms.Padding(2);
            this.txtGcode.Multiline = true;
            this.txtGcode.Name = "txtGcode";
            this.txtGcode.Size = new System.Drawing.Size(639, 251);
            this.txtGcode.TabIndex = 9;
            this.txtGcode.Text = "G91";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox4.Controls.Add(this.btnSelectFile);
            this.groupBox4.Controls.Add(this.txtPath);
            this.groupBox4.Location = new System.Drawing.Point(28, 22);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(7);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(7);
            this.groupBox4.Size = new System.Drawing.Size(511, 127);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Step 1: Select Gcode";
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(322, 38);
            this.btnSelectFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(175, 45);
            this.btnSelectFile.TabIndex = 4;
            this.btnSelectFile.Text = "Browse";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click_1);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(9, 38);
            this.txtPath.Margin = new System.Windows.Forms.Padding(2);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(303, 35);
            this.txtPath.TabIndex = 3;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.btnRemove);
            this.groupBox5.Controls.Add(this.btnInsert);
            this.groupBox5.Controls.Add(this.numCut);
            this.groupBox5.Controls.Add(this.CutList);
            this.groupBox5.Location = new System.Drawing.Point(28, 183);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(7);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(7);
            this.groupBox5.Size = new System.Drawing.Size(534, 544);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Step 2: Select layers to cut";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(22, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(364, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "otherwise nozzle will hit the print!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(22, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(337, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "keep intervals in correct order!";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(56, 495);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(427, 42);
            this.btnRemove.TabIndex = 10;
            this.btnRemove.Text = "Delete selected cut";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(56, 116);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(264, 42);
            this.btnInsert.TabIndex = 9;
            this.btnInsert.Text = "Add cut at layer";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // numCut
            // 
            this.numCut.Location = new System.Drawing.Point(327, 116);
            this.numCut.Margin = new System.Windows.Forms.Padding(2);
            this.numCut.Name = "numCut";
            this.numCut.Size = new System.Drawing.Size(159, 35);
            this.numCut.TabIndex = 8;
            // 
            // CutList
            // 
            this.CutList.FormattingEnabled = true;
            this.CutList.ItemHeight = 29;
            this.CutList.Location = new System.Drawing.Point(56, 167);
            this.CutList.Margin = new System.Windows.Forms.Padding(2);
            this.CutList.Name = "CutList";
            this.CutList.Size = new System.Drawing.Size(426, 323);
            this.CutList.TabIndex = 7;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox6.Controls.Add(this.btnGen);
            this.groupBox6.Location = new System.Drawing.Point(28, 741);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(7);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(7);
            this.groupBox6.Size = new System.Drawing.Size(467, 223);
            this.groupBox6.TabIndex = 17;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Step 3: generate Gcode";
            // 
            // btnGen
            // 
            this.btnGen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGen.Location = new System.Drawing.Point(56, 69);
            this.btnGen.Margin = new System.Windows.Forms.Padding(2);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(357, 87);
            this.btnGen.TabIndex = 8;
            this.btnGen.Text = "Generate separated Gcodes";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1595, 1938);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtShowFile);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCut)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtShowFile;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbABS;
        private System.Windows.Forms.RadioButton rbREL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtGcode;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.NumericUpDown numCut;
        private System.Windows.Forms.ListBox CutList;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

