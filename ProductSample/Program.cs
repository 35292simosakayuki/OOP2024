using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSample {
    internal class Program {
        static void Main(string[] args) {
            Product karinto = new Product(123, "かりんとう", 180);
            Product daihuku = new Product(132, "だいふく", 200);
            Product dorayaki = new Product(98, "どら焼き", 210);
            int price = karinto.price;
            int taxIncluded = karinto.GetPriceIncludingTax();

            int daihukuprice = daihuku.price;
            int daihukutaxIncluded = daihuku.GetPriceIncludingTax();

            int dorayakiprice = dorayaki.price;
            int dorayakitaxIncluded = dorayaki.GetPriceIncludingTax();

            Console.WriteLine
                (karinto.Name+"の"+"税込金額"+taxIncluded+"円【税抜き"+karinto.price+"円】");

            Console.WriteLine
                (daihuku.Name+"の"+"税込金額"+daihukutaxIncluded+"円【税抜き"+daihukuprice+"円】");

            Console.WriteLine
                            (dorayaki.Name+"の"+"税込金額"+dorayakitaxIncluded+"円【税抜き"+dorayakiprice+"円】");

        }
    }

}

