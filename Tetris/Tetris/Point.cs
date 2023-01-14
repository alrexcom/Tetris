using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
  public  class Point
    {
      public  int x, y;
      public  char c;
      public void Draw()
        {
            Console.SetCursorPosition(x, y);         
            Console.WriteLine(c);
            Console.SetCursorPosition(0, 0);
        }

        internal void Move(Action dir)
        {
            switch (dir)
            {
                case Action.left:
                    x -= 1;
                    break;
                case Action.right:
                    x += 1;
                    break;
                case Action.down:
                    y += 1;
                    break;               
            }
        }

        internal void Hide()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(" ");
        }

        public Point(int x, int y, char symv)
        {
            this.x = x;
            this.y = y;
            this.c = symv;
        }
        public Point()
        {

        }

        public Point(Point point)
        {
            this.x = point.x;
            this.y = point.y;
            this.c = point.c;
        }
    }
}
