using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample0411 {
    internal class Program {
        static void Main(string[] args) {
            int[] nums = new int[10];   //０～９
            Console.WriteLine("0～9の数字を入力（-1で終了）");
            int num;
            while (true) {
                Console.Write(">");
                num = int.Parse(Console.ReadLine());
                if (num == -1)
                    break;
                
                nums[num]++;   //カウント
            }

            Console.WriteLine("入力された数字の個数");
            for (int i = 0; i < nums.Length; i++) {
                Console.Write( i + ":");
                astOut(nums[i]);
                Console.WriteLine();
            }
        }

        //指定した数のアスタリスクを出力
        public static void astOut(int num) {
            for (int j = 0; j < num; j++) {
                Console.Write("*");
            }
        }
    }
}
