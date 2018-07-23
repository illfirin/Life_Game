using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LifeGame
{

    class LifeCell
    {
        public int x_cord { get; private set; }
        public int y_cord { get; private set; }
        public Rectangle bounds { get; private set; }
        private bool IsAlive { get; set; }

        public LifeCell(int x,int y)
        {
            x_cord = x;
            y_cord = y;
            //bounds = new Rectangle(x*)
        }
   

    }
}
