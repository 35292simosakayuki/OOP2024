﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
    internal class Program {
        static void Main(string[] args) {
            if (args.Length>=1&&args[0]=="-tom") {
                PrintFeetToMeterList(int.Parse(args[1]),int.Parse(args[2]));
            } else {
                PrintMeterToFeetList(int.Parse(args[1]),int.Parse(args[2]));
            }
        }
        private static void PrintFeetToMeterList(int start, int stop) {  
            for (int feet = start; feet<=stop; feet++) {
                double meter = FeetConverter.FromMeter(feet);
                Console.WriteLine("{0}ft={1:0.0000}m", feet, meter);
            }
        }
        private static void PrintMeterToFeetList(int start, int stop) {
            for (int meter = start; meter<=stop; meter++) {
                double feet = FeetConverter.ToMeter(meter);
                Console.WriteLine("{0}m={1:0.0000}ft", meter, feet);
            }
        }
    }
}

