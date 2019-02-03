using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GcodeDivider
{
    class itCut
    {
        //M104: set nozzle temp
        //M109: set nozzle temp ad wait

        //M140: set bed temp fast
        //M190: set bed temp and wait

        public int layer = 0;
        public int nozzleTempStart = -1; //M104 S#
        public int bedTempStart = -1;
        public int fanStart = -1;        //M106 S#

        //public int nozzleTempEnd = -1;   //not used for now
        //public int bedTempEnd = -1;      //not used for now
        //public int fanEnd = -1;          //not used for now

        public itCut(int layer)
        {
            this.layer = layer;
        }

        public override String ToString()
        {
            String toret = "Between Layer " + (layer) + " and " + (layer + 1);

            if (layer == 0)
                return "Initial part";

            if (layer == -1)
                return "Final part";


            return toret;
        }
    }
}
