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
    }
}
