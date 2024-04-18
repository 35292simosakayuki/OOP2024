using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSample {
    internal class Product {
        //商品コード
        public int Code { get; set; }
        //商品名
        public string Name { get; set; }
        //商品価格（税抜）
        public int price { get; set; }


        public Product(int code, string name, int price) {

            this.Code = code;
            this.Name = name;
            this.price = price;
        }

        public int GetTax() {
            return (int)(price*0.08);
        }
        public int GetPriceIncludingTax() {
            return price +GetTax();
        }

    }
}
