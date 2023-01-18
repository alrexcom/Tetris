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
        public override void Rotate()
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
        public override void Rotate()
        {
            if (Points[0].X == Points[1].X)
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
            for (int i = 0; i < Points.Length; i++)
            {
                Points[i].X = Points[0].X;
                Points[i].Y = Points[0].Y + i;
            }
        }

        private void RotateHorizontal()
        {
            for (int i = 0; i < Points.Length; i++)
            {
                Points[i].Y = Points[0].Y;
                Points[i].X = Points[0].X + i;
            }
        }
    }
}
