using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Figure
    {
        protected Point[] points = new Point[4];

        public void Draw()
        {
            foreach (var item in points)
            {
                item.Draw();
            }
        }
    }
}
