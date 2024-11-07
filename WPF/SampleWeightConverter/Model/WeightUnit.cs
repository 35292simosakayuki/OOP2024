using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleWeightConverter {
    public class WeightUnit :PoundUnit{
        private static List<WeightUnit> units = new List<WeightUnit> {
            new WeightUnit{ Name = "OZ",Coefficient = 1,},
            new WeightUnit{ Name = "IB",Coefficient = 16,},
        };
        public static ICollection<WeightUnit> Units { get { return units; } }

        /// <summary>
        /// メートル単位からヤード単位に変換します
        /// </summary>
        /// <param name="unit">メートル単位</param>
        /// <param name="value">値</param>
        /// <returns></returns>
        public double FromMetricUnit(GramUnit unit, double value) {
            return (value * unit.Coefficient)  / this.Coefficient;
        }
    }
}
