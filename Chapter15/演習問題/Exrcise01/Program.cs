using Section01;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exrcise01 {
    internal class Program {
        static void Main(string[] args) {
            Exercise1_2();
            Console.WriteLine();
            Exercise1_3();
            Console.WriteLine();
            Exercise1_4();
            Console.WriteLine();
            Exercise1_5();
            Console.WriteLine();
            Exercise1_6();
            Console.WriteLine();
            Exercise1_7();
            Console.WriteLine();
            Exercise1_8();

            Console.ReadLine();
        }

        private static void Exercise1_2() {
            var max = Library.Books.Max(x => x.Price);
            var book = Library.Books.First(b => b.Title.Length==max);
            Console.WriteLine(book);

        }

        private static void Exercise1_3() {
            var quary = Library.Books.GroupBy(x => x.PublishedYear)
                 .Select(g => new { PublishedYear = g.Key, Count = g.Count() }).OrderBy(g => g.PublishedYear);
            foreach (var x in quary) {
                Console.WriteLine("{0}年 {1}冊", x.PublishedYear, x.Count);
            }
        }

        private static void Exercise1_4() {
            var quary = Library.Books.Join(Library.Categories, book => book.CategoryId, category => category.Id,
                (book, category) => new {
                    book.Title,
                    book.PublishedYear,
                    book.Price,
                    CategoryName = category.Name,
                }).OrderByDescending(x => x.PublishedYear)
                .ThenByDescending(x => x.Price);

            foreach (var x in quary)
                Console.WriteLine("{0}年　{1}円　{2} ({3})",
                x.PublishedYear,
                x.Price,
                x.Title,
                x.CategoryName
                );
        }

        private static void Exercise1_5() {
        //    var quary = Library.Books.GroupBy(x => x.PublishedYear==2016)
        //        .Join(Library.Categories,
        //       book => book.CategoryId,
        //        category => category.Id,
       //         (book, category) => category.Name).Distinct();
//
       //     foreach (var x in quary) {
       //         Console.WriteLine(x);
       //     }
       }

        private static void Exercise1_6() {
        //    var quary=Library.Books.Join(Library.Categories,
        //        book=>book.CategoryId,

        }

        private static void Exercise1_7() {
            var categoriesId = Library.Categories.Where(c => c.Name=="Development").Id;
            var quary = Library.Books.Where(b => b.CategoryId==categoriesId)
            .Groupby(b => b.PublishedYear)
            .OrderBy(b => b.Key);
            foreach (var x in quary) {
                Console.WriteLine("#{0}年",x.Key);
                foreach(var y in x) { 
                Console.WriteLine(" {0}",y.Title); 
                }
            }
        }

        private static void Exercise1_8() {
            throw new NotImplementedException();
        }
    }
}
