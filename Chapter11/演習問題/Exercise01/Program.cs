using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            var file = "sample.xml";
            Exercise1_1(file);
            Console.WriteLine();
            Exercise1_2(file);
            Console.WriteLine();
            Exercise1_3(file);
            Console.WriteLine();

            var newfile = "sports.xml";
            Exercise1_4(file, newfile);

        }

        private static void Exercise1_1(string file) {
            var xdoc = XDocument.Load(file);
            var sports = xdoc.Root.Elements()
                             .Select(x => new {
                                 Name = x.Element("name").Value,
                                 Teammembers = x.Element("teammembers").Value
                             });
            foreach (var sport in sports) {
                Console.WriteLine("{0} {1}", sport.Name, sport.Teammembers);
            }
        }

        private static void Exercise1_2(string file) {
            var xdoc = XDocument.Load(file);
            var sports = xdoc.Root.Elements()
                            .Select(x => new {
                                Name = x.Element("name").Attribute("kanji").Value,
                                Firstplayed = x.Element("firstplayed").Value,
                            }).OrderBy(x => x.Firstplayed);

            foreach (var sport in sports) {
                Console.WriteLine("{0}({1})", sport.Name, sport.Firstplayed);
            }

        }

        private static void Exercise1_3(string file) {
            var xdoc1 = XDocument.Load(file);
            var sport = xdoc1.Root.Elements().Select(x => new {
                Name = x.Elements("name").Value,
                Teammenbers = x.Elements("teammembers").Value,
            })
                .OrderByDescending(x => int.Parse(x.Teammembers))
                .First();
            Console.WriteLine("{0}", sport.Name);
        }

        private static void Exercise1_4(string file, string newfile) {
            List<XElement> xElements = new List<XElement>();
            var xdoc = XDocument.Load(file);
            string name, teammember, firstplayed, kanji;
            int nextflag;
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
                xElements.Add(element);
                Console.WriteLine();
                Console.Write("追加【1】 保存【2】");
                Console.Write(">");
                nextflag=int.Parse(Console.ReadLine());
                if (nextflag== 2) break;
                Console.WriteLine();
                xdoc.Root.Add(element);
                xdoc.Save(newfile);
            }
        }
    }
}

