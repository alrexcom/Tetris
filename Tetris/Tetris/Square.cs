using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Square:Figure
    {
       

        public Square(int x, int y, char symb) 
        {       
            points[0] = new Point(x,y,symb);
            points[1] = new Point(x+1,y,symb);
            points[2] = new Point(x,y+1,symb);
            points[3] = new Point(x+1,y+1,symb);
        }

    }


    class Stick : Figure
    {
        public Stick(int x, int y, char symb)
        {
            points[0] = new Point(x, y, symb);
            points[1] = new Point(x, y + 1, symb);
            points[2] = new Point(x, y + 2, symb);
            points[3] = new Point(x, y + 3, symb);
        }

    }
}
