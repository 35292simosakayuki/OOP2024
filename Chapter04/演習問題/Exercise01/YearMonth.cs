﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {

    public class YearMonth {
        // 4.1.1
        public int Year { get; private set; }
        public int Month { get; private set; }

        //コンストラクタ
        public YearMonth(int year, int month) {
            Year = year;
            Month = month;
        }

        // 4.1.2
        public bool Is21Century {
            get {
                return 2001 <= Year && Year <= 2100;
            }
        }

        // 4.1.3
        public YearMonth AddOneMonth() {
            return new YearMonth(Year, Month + 1);  //ダミー
        }

        // 4.1.4
        public override string ToString() {
            return "〇〇〇〇〇"; //ダミー
        }
    }        
}
