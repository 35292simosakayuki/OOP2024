using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("年:");
            int year = int.Parse( Console.ReadLine());

            Console.Write("月:");
            int mounth = int.Parse(Console.ReadLine());

            Console.Write("日:");
            int day = int.Parse(Console.ReadLine());



            var birthday = new DateTime(year, mounth, day);
            
            switch(birthday.DayOfWeek){
                case ()1:
                    Console.WriteLine("あなたは"+birthday+"曜日に生まれました");
                    break;
            }

            
        }
    }
}
