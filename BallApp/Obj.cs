﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallApp {
    internal class Obj {
        public Image? Image { get; set; }
        public double PosX { get; set; }
        public double PosY { get; set; }
        public double MoveX { get; set; }
        public double MoveY { get; set; }

        public Obj(double posX,double posY,string path) {
        PosX = posX;
            PosY = posY;
            Image = Image.FromFile(path);
        }
        public abstract bool Move();
    }
}
