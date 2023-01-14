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
            Draw();
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
            Draw();
        }
        public override void Rotate()
        {
            
            Hide();
            var clone =  Clone();             

            if (points[0].x == points[1].x)
            {
                RotateHorizontal(clone);
            }
            else
            {
               RotateVertical(clone);
            }
            if (VerifyPosition(clone))
                points = clone;
                Draw();
        }                   

        private void RotateVertical(Point[] p)
        {
            for (int i = 0; i < Config.POINTCOUNT; i++)
            {
                p[i].x = p[0].x;
                p[i].y = p[0].y + i;
            }
        }

        private void RotateHorizontal(Point[] p)
        {
            for (int i = 0; i < points.Length; i++)
            {               
                p[i].y = p[0].y;
                p[i].x = p[0].x + i;
            }
        }
    }
}
