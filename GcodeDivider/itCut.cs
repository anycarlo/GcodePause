using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GcodeDivider
{
    class itCut
    {
        public int layer = 0;

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
