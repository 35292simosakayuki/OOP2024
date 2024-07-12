﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarReportSystem {
    public class Settings {
        private static Settings instance;

        public int MainFormColor { get; set; }
        //コンストラクタ
        private Settings() {　}

        public static Settings getInstance() {
            if (instance == null) {
                instance=new Settings();
            }
            return instance;
        }
    }
}
