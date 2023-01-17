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
        public Point[] Points = new Point[Config.POINTS_COUNT];

        public void Draw()
        {
            foreach (var item in Points)
            {
                item.Draw();
            }
        }
        internal Result TryMove(Action dir)
        {
            Hide();
            var clone = Clone();
            Move(clone, dir);

            var result = (VerifyPosition(clone));
            if (result == Result.SUCCESS)
                Points = clone;
            Draw();

            return result;
        }

        internal Result TryRotate()
        {
            Hide();
            var clone = Clone();
            Rotate(clone);

            var result = (VerifyPosition(clone));
            if (result == Result.SUCCESS)
                Points = clone;
            Draw();

            return result;
        }

        public abstract void Rotate(Point[] clone);

        public Result VerifyPosition(Point[] pList)

        {
            foreach (var p in pList)
            {
                if (p.Y >= Config.Height - 1)
                    return Result.BORDER_DOWN_STRICKE;

                if (p.X >= Config.Width || p.X < 0 || p.Y < 0)
                    return Result.BORDER_STRICKE;

                if (Config.CheckStrike(p))
                    return Result.HEAP_STRICKE;
            }
            return Result.SUCCESS;
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
                newPoints[i] = new Point(Points[i]);
            }
            return newPoints;
        }


        public void Hide()
        {
            //Thread.Sleep(500);
            foreach (var item in Points)
            {
                item.Hide();
            }

        }




    }
}
