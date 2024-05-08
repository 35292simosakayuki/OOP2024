using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallApp {
    internal class Soccerball : Obj{
        public Soccerball(double xp,double yp) 
            :base(xp,yp,@"picture\soccer_ball.png"){
            MoveX=10;
            MoveY=10;
        }
        public override bool Move() {
            PosX+=MoveX;
            PosY+=MoveY;

            return true;
        }
    }
}
