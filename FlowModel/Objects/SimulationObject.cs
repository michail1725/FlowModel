using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowModel.Objects
{
    public static class SimulationObject
    {
        public static Canal canal { get; set; }
        public static Material material {get;set;}
        public static double step { get; set; }
    }
}
