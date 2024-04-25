using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {
    internal class InchiConverter {
        public static readonly double ratio = 0.0254;

        public static double FromMeter(double meter) {
            return meter/ratio;
        }
        public static double ToMeter(double Inchi) {
            return Inchi*ratio;
        }
    }
}
