using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };

            Exercise1_1(numbers);

            Console.WriteLine("-----");

            Exercise1_2(numbers);
            Console.WriteLine("-----");

            Exercise1_3(numbers);
            Console.WriteLine("-----");

            Exercise1_4(numbers);
            Console.WriteLine("-----");

            Exercise1_5(numbers);
        }

        private static void Exercise1_1(int[] numbers) {
            var number= numbers.Max();
            Console.WriteLine(number);
        }

        private static void Exercise1_2(int[] numbers) {
            var number=numbers.Skip(9).;
        }

        private static void Exercise1_3(int[] numbers) {
            var str =numbers.Select(x => x.ToString()).ToArray();
            foreach(var num in str)
                Console.WriteLine(num);
        }

        private static void Exercise1_4(int[] numbers) {
            var sorted = numbers.OrderBy(x => x);

        }

        private static void Exercise1_5(int[] numbers) {
            var results = numbers.Distinct();
            
            foreach (int n in numbers) {
            if(n>0) {
                    results.Add(n);
                    if (results.Count()>10)
                        break;
                    
                }
            }
        }
    }
}
