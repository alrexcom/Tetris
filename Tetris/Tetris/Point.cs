using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char C { get; set; }
        public void Draw()
        {
            Console.SetCursorPosition(X, Y);
            Console.WriteLine(C);
            Console.SetCursorPosition(0, 0);
        }

        internal void Move(Action dir)
        {
            switch (dir)
            {
                case Action.LEFT:
                    X -= 1;
                    break;
                case Action.RIGHT:
                    X += 1;
                    break;
                case Action.DOWN:
                    Y += 1;
                    break;
            }
        }

        internal void Hide()
        {
            Console.SetCursorPosition(X, Y);
            Console.WriteLine(" ");
        }

        public Point(int x, int y, char symv)
        {
            this.X = x;
            this.Y = y;
            this.C = symv;
        }    

        public Point(Point point)
        {
            this.X = point.X;
            this.Y = point.Y;
            this.C = point.C;
        }
    }
}
