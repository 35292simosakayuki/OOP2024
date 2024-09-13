﻿using SampleEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SampleEntityFramework {
    internal class Program {
        static void Main(string[] args) {
            //InsertBooks();
            DisplayAllBooks2();
            AddBooks();
            //AddAuthors();
        }
        private static void DeleteBooks() {
            using (var db = new BooksDbContext()) {
                var book = db.Books.SingleOrDefault(x => x.Id==10);
                if (book !=null) {
                    db.Books.Remove(book);
                    db.SaveChanges();
                }
            }
        }
        private static void UpdateBooks() {
            using (var db = new BooksDbContext()) {
                var book = db.Books.Single(x => x.Title=="銀河鉄道の夜");
                book.PublishedYear=2016;
                db.SaveChanges();
            }
        }

        static IEnumerable<Book> GetBooks() {
            using (var db = new BooksDbContext()) {
                return db.Books
                    .Where(book => book.Author.Name.StartsWith("夏目"))
                    .ToList();
            }
        }
        static void DisplayAllBooks() {
            var books = GetBooks();
            foreach (var book in books) {
                Console.WriteLine($"{book.Title}{book.PublishedYear}");
            }
            Console.ReadLine();
        }
        static void DisplayAllBooks2() {
            using (var db = new BooksDbContext()) {
                foreach (var book in db.Books.ToList()) {
                    Console.WriteLine("{0}{1}{2}({3:yyyy/MM/dd})",
                        book.Title, book.PublishedYear,
                        book.Author.Name, book.Author.Birthday
                        );
                }
                Console.ReadLine();
            }
        }
        private static void AddAuthors() {
            using (var db = new BooksDbContext()) {
                //Authorから該当するデータを取得する
                
                var author1 = new Author {
                    Birthday= new DateTime(1888, 12, 26),
                    Gender="M",
                    Name="菊池寛",
                };
                db.Authors.Add(author1);
                var author2 = new Author {
                    Birthday= new DateTime(1899, 6, 14),
                    Gender="M",
                    Name="川端康成",
                };
                db.Authors.Add(author2);
                db.SaveChanges();
            }
        }
        private static void AddBooks() {
            using (var db = new BooksDbContext()) {
                var author1 = db.Authors.Single(a => a.Name=="夏目漱石");
                var book1 = new Book {
                    Title="こころ",
                    PublishedYear=1991,
                    Author=author1,
                };
                db.Books.Add(book1);
                var author2 = db.Authors.Single(a => a.Name=="川端康成");
                var book2 = new Book {
                    Title="伊豆の踊子",
                    PublishedYear=2003,
                    Author=author2,
                };
                db.Books.Add(book2);
                var author3 = db.Authors.Single(a => a.Name=="菊池寛");
                var book3 = new Book {
                    Title="真珠夫人",
                    PublishedYear=2002,
                    Author=author3,
                };
                db.Books.Add(book3);
                var author4 = db.Authors.Single(a => a.Name=="宮沢賢治");
                var book4 = new Book {
                    Title="注文の多い料理店",
                    PublishedYear=2000,
                    Author=author4,
                };
                db.Books.Add(book4);
                db.SaveChanges();
            }
        }

    }
}
