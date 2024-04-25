using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample0410 {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("数値を入力：");
            int inputNum = int.Parse(Console.ReadLine());   //入力

            Console.WriteLine("①--------");
            for (int i = 0; i < inputNum; i++) {
                for (int j = 0; j < inputNum; j++) {
                    Console.Write("＊");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("②--------");

            for (int i = 0; i < inputNum; i++) {
                for (int j = 0; j < i + 1; j++) {
                    Console.Write("＊");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("③--------");

            for (int i = 0; i < inputNum; i++) {
                for (int j = 0; j < inputNum - i; j++) {
                    Console.Write("＊");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("④--------");

            for (int i = 0; i < inputNum; i++) {
                //空白
                for (int j = 0; j < i + 1; j++) {
                    Console.Write("　");
                }
                //アスタリスク
                for (int k = 0; k < inputNum - i; k++) {
                    Console.Write("＊");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("⑤--------");

            for (int i = 0; i < inputNum; i++) {
                //空白
                for (int j = 0; j < inputNum - i; j++) {
                    Console.Write("　");
                }
                //アスタリスク
                for (int k = 0; k < i + 1; k++) {
                    Console.Write("＊");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("⑥--------");

            for (int i = 0; i < inputNum; i++) {
                //空白
                for (int j = 0; j < inputNum - i; j++) {
                    Console.Write(" ");
                }
                //アスタリスク
                for (int k = 0; k < i + 1; k++) {
                    Console.Write("＊");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("⑦--------");

            for (int i = 0; i < inputNum; i++) {
                //空白
                for (int j = 0; j < i + 1; j++) {
                    Console.Write(" ");
                }
                //アスタリスク
                for (int k = 0; k < inputNum - i; k++) {
                    Console.Write("＊");
                }
                Console.WriteLine();
            }
        }
    }
}
