using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    abstract class Figure
    {
        //public const int cPointCount = 4;
        protected Point[] points = new Point[Config.POINTS_COUNT];

        public void Draw()
        {
            foreach (var item in points)
            {
                item.Draw();
            }
        }
        public void TryMove(Action dir)
        {
            Hide();
            var clone = Clone();
            Move(clone, dir);
            if (VerifyPosition(clone))
                points = clone;

            Draw();
        }

        public bool VerifyPosition(Point[] pList)

        {
            foreach (var item in pList)
            {
                if (item.X < 0 || item.Y < 0 || item.X >= Config.Width || item.Y >= (Config.Height - 1))
                    return false;
            }
            return true;
        }

        public void Move(Point[] pList, Action dir)
        {
            foreach (var item in pList)
            {
                item.Move(dir);
            }
        }

        public Point[] Clone()
        {
            var newPoints = new Point[Config.POINTS_COUNT];
            for (int i = 0; i < Config.POINTS_COUNT; i++)
            {
                newPoints[i] = new Point(points[i]);
            }
            return newPoints;
        }

        //public void Move(Action dir)
        //{
        //    Hide();
        //    foreach (var item in points)
        //    {
        //        item.Move(dir);
        //    }
        //    Draw();
        //}

        public void Hide()
        {
            //Thread.Sleep(500);
            foreach (var item in points)
            {
                item.Hide();
            }

        }

        public abstract void Rotate();

    }
}
