﻿using Section01;
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
            var query = Library.Books
                            .Where(b => b.PublishedYear == 2016)
                            .Join(Library.Categories,   //結合する２番目のシーケンス
                                    book => book.CategoryId,//対象シーケンスの結合キー
                                    category => category.Id,//２番目のシーケンスの結合キー
                                    (book, category) => category.Name)
                            .Distinct();

            foreach (var name in query)
                Console.WriteLine(name);
        }

        private static void Exercise1_6() {
            var query = Library.Books
                            .Join(Library.Categories,   //結合する２番目のシーケンス
                                    book => book.CategoryId,//対象シーケンスの結合キー
                                    category => category.Id,//２番目のシーケンスの結合キー
                                    (book, category) => new {
                                        book.Title,
                                        CategoryName = category.Name
                                    })
                            .GroupBy(x => x.CategoryName)
                            .OrderBy(x => x.Key);
            foreach (var group in query) {
                Console.WriteLine("#{0}", group.Key);
                foreach (var item in group) {
                    Console.WriteLine("  {0}", item.Title);
                }
            }
        }

        private static void Exercise1_7() {
            var categoriesId = Library.Categories.Single(c => c.Name == "Development").Id;
            var query = Library.Books.Where(b => b.CategoryId == categoriesId)
                                        .GroupBy(b => b.PublishedYear)
                                        .OrderBy(b => b.Key);
            foreach (var group in query) {
                Console.WriteLine("#{0}年", group.Key);
                foreach (var item in group) {
                    Console.WriteLine("  {0}", item.Title);
                }
            }
        }

        private static void Exercise1_8() {
            var quary=Library.Categories.GroupJoin(Library.Books,
                c=>c.Id,
                b=>b.CategoryId,
                (c, b) => new {
                    CategoryName=c.Name,
                    count=b.Count()
                });
            foreach (var x in quary) {
                Console.WriteLine(x.CategoryName+"("+x.count+")");
            }
        }
    }
}
