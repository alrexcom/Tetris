using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Point
    {
      public  int x, y;
      public  char c;
      public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(c);
        }
    }
}
