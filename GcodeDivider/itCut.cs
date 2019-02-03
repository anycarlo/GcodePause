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
        public int nozzleTempStart = 0; //M104 S#
        public int nozzleTempEnd = 0;   //M104 S#
        public int bedTempStart = 0;    
        public int bedTempEnd = 0;      
        public int fanStart = 0;        //M106 S#
        public int fanEnd = 0;          //M106 S#

        public itCut(int layer)
        {
            this.layer = layer;
        }

        public override String ToString()
        {
            String toret = "Between Layer " + (layer) + " and " + (layer+1);
            return toret;
        }
    }
}
