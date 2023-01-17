using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Square : Figure
    {


        public Square(int x, int y, char symb)
        {
            Points[0] = new Point(x, y, symb);
            Points[1] = new Point(x + 1, y, symb);
            Points[2] = new Point(x, y + 1, symb);
            Points[3] = new Point(x + 1, y + 1, symb);
            Draw();
        }
        public override void Rotate(Point[] clone)
        {

        }
    }

    class Stick : Figure
    {
        public Stick(int x, int y, char symb)
        {
            Points[0] = new Point(x, y, symb);
            Points[1] = new Point(x, y + 1, symb);
            Points[2] = new Point(x, y + 2, symb);
            Points[3] = new Point(x, y + 3, symb);
            Draw();
        }
        public override void Rotate(Point[] clone)
        {
            if (Points[0].X == Points[1].X)
            {
                RotateHorizontal(clone);
            }
            else
            {
                RotateVertical(clone);
            }    
        }

        private void RotateVertical(Point[] p)
        {
            for (int i = 0; i < Config.POINTS_COUNT; i++)
            {
                p[i].X = p[0].X;
                p[i].Y = p[0].Y + i;
            }
        }

        private void RotateHorizontal(Point[] p)
        {
            for (int i = 0; i < Config.POINTS_COUNT; i++)
            {
                p[i].Y = p[0].Y;
                p[i].X = p[0].X + i;
            }
        }
    }
}
