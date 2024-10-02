using Section01;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
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
                (book, category) => new
                { book.Title, book.PublishedYear, book.Price, CategoryName = category.Name,
                }).OrderByDescending(x=>x.PublishedYear)
                .ThenByDescending(x=>x.Price);

            foreach (var x in quary)
                Console.WriteLine("{0}年　{1}円　{2} ({3})",
                x.PublishedYear,
                x.Price,
                x.Title,
                x.CategoryName
                );
        }

        private static void Exercise1_5() {
            throw new NotImplementedException();
        }

        private static void Exercise1_6() {
            throw new NotImplementedException();
        }

        private static void Exercise1_7() {
            throw new NotImplementedException();
        }

        private static void Exercise1_8() {
            throw new NotImplementedException();
        }
    }
}
