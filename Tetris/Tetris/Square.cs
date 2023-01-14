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

            if (points[0].X == points[1].X)
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
                p[i].X = p[0].X;
                p[i].Y = p[0].Y + i;
            }
        }

        private void RotateHorizontal(Point[] p)
        {
            for (int i = 0; i < points.Length; i++)
            {               
                p[i].Y = p[0].Y;
                p[i].X = p[0].X + i;
            }
        }
    }
}
