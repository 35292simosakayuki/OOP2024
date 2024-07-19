using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Section02 {
    internal class Program {
        static void Main(string[] args) {
            AddElement();
        }
        public static void AddElement() {
            List<XElement> list = new List<XElement>();

            string name, teammember, firstplayed, kanji;
            int  nextflag;
            while (true) {
                Console.WriteLine("名称:");
                name = Console.ReadLine();
                Console.WriteLine("漢字:");
                kanji = Console.ReadLine();
                Console.WriteLine("人数:");
                teammember = Console.ReadLine();
                Console.WriteLine(":");
                firstplayed = Console.ReadLine();

                var element = new XElement("ballsport",
                    new XElement("name", name, new XAttribute("kanji", kanji)),
                    new XElement("teammember", teammember.ToString()),
                    new XElement("firstplayed", firstplayed.ToString())
                  );
                list.Add(element);
                Console.WriteLine();
                Console.Write("追加【1】 保存【2】");
                Console.Write(">");
                nextflag=int.Parse(Console.ReadLine());
                if (nextflag== 2) break;
                Console.WriteLine();
            }
            
        }
    }
}
