using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    abstract class Figure
    {
        protected Point[] points = new Point[4];

        public void Draw()
        {
            foreach (var item in points)
            {
                item.Draw();
            }
        }

        public void Move(Action dir)
        {
            Hide();
            foreach (var item in points)
            {
                item.Move(dir);
            }
            Draw();
        }

        public void Hide()
        {
            Thread.Sleep(500);
            foreach (var item in points)
            {                
                item.Hide();
            }
           
        }

       public abstract void Rotate();
    }
}
