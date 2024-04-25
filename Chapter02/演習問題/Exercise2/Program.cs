using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {
    internal class Program {
        static void Main(string[] args) {
            if (args.Length>=1&&args[0]=="-tom") {
                PrintInchiToMeterList(int.Parse(args[1]), int.Parse(args[2]));
            } else {
                PrintMeterToInchiList(int.Parse(args[1]), int.Parse(args[2]));
            }

        }
        private static void PrintInchiToMeterList(int start, int stop) {
            for (int Inchi = start; start<=stop; Inchi++) {
                double meter = InchiConverter.FromMeter(Inchi);
                Console.WriteLine("{0}Inchi={1:0.0000}m", Inchi, meter);
            }
        }
        private static void PrintMeterToInchiList(int start, int stop) {
            for (int meter = start; meter<=stop; meter++) {
                double Inchi = InchiConverter.ToMeter(meter);
                Console.WriteLine("{0}m={1:0.0000}ft", meter, Inchi);

            }
        }
    }
}
