using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {
            var names = new List<string> {
              "Tokyo",
              "New Delhi",
              "Bangkok",
              "Paris",
              "Bariln",
              "Canberra",
              "Hong kong",
          };
            IEnumerable<string>query=names.Where(s=>s.Contains(' '))
                .Select(s=>s.ToUpper());
            foreach(string s in query)
                Console.WriteLine(s);
        }
    }
}
