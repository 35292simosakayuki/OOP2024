using System;
using System.Collections.Generic;
using System.IO;

namespace SalesCounter {
    public class SalesCounter {
        private IEnumerable<Sale> _sales;

        public SalesCounter(string filePass) {
            _sales=ReadSales(filePass);
        }

        private static IEnumerable<Sale> ReadSales(string filePath) {
            List<Sale> sales = new List<Sale>();
            string[] lines = File.ReadAllLines(filePath);
            foreach (String line in lines) {
                string[] items = line.Split(',');
                Sale sale = new Sale {
                    ShopName=items[0],
                    ProductCategory=items[1],
                    Amount=int.Parse(items[2])
                };
                sales.Add(sale);
            }
            return sales;
        }

        public IDictionary<string, int> GetPerStoreSales() {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (Sale sale in _sales) {
                if (dict.ContainsKey(sale.ProductCategory)) {
                    dict[sale.ProductCategory]+=sale.Amount;
                } else {
                    dict[sale.ProductCategory] = sale.Amount;
                }
            }
            return dict;
        }
    }
}
