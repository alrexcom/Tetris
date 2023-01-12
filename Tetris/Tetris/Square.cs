using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    internal class Square
    {
        Point[] points = new Point[4];

        public Square(int x, int y, char symb) 
        {         

            points[0] = new Point(x,y,symb);
            points[1] = new Point(x+1,y,symb);
            points[2] = new Point(x,y+1,symb);
            points[3] = new Point(x+1,y+1,symb);
        }

        public void Draw()
        {
            foreach (var item in points)
            {
                item.Draw();
            }
        }
    }


    internal class Stick
    {
        Point[] points = new Point[10];

        public Stick(int x, int y, char symb)
        {

            points[0] = new Point(x, y, symb);
            points[1] = new Point(x, y+1, symb);
            points[2] = new Point(x, y+2 , symb);
            points[3] = new Point(x, y + 3, symb);
            points[4] = new Point(x, y + 4 , symb);
            points[5] = new Point(x + 1, y , symb);
            points[6] = new Point(x + 1, y+1 , symb);
            points[7] = new Point(x + 1, y+2 , symb);
            points[8] = new Point(x + 1, y+3 , symb);
            points[9] = new Point(x + 1, y+4 , symb);
        }

        public void Draw()
        {
            foreach (var item in points)
            {
                item.Draw();
            }
        }
    }
}
