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
        public override void Rotate()
        {
           
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
        public override void Rotate()
        {
            if (points[0].x == points[1].x)
            {
                RotateHorizontal();
            }
            else
            {
                RotateVertical();
            }

        }

        private void RotateVertical()
        {
            for (int i = 0; i < points.Length; i++)
            {
                points[i].x = points[0].x;
                points[i].y = points[0].y + i;
            }
        }

        private void RotateHorizontal()
        {
            for (int i = 0; i < points.Length; i++)
            {               
                points[i].y = points[0].y;
                points[i].x = points[0].x + i;
            }
        }
    }
}
