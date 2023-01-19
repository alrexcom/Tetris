using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    abstract class Figure
    {
    
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
            Move(dir);

            var result = (VerifyPosition());
            if (result != Result.SUCCESS)
                Move(Reverse(dir));
            Draw();

            return result;
        }

        internal Result TryRotate()
        {
            Hide();
            Rotate();

            var result = (VerifyPosition());
            if (result != Result.SUCCESS)
                Rotate();
            Draw();

            return result;
        }

        public abstract void Rotate();
       

        public Action Reverse(Action dir)
        {
            switch (dir)
            {
                case Action.LEFT:
                    return Action.RIGHT;
                case Action.RIGHT:
                    return Action.LEFT;
                case Action.DOWN:
                    return Action.UP;
                case Action.UP:
                    return Action.DOWN;
            }
            return dir;
        }

        public Result VerifyPosition()

        {
            foreach (var p in Points)
            {
                if (p.Y >= Config.Height )
                    return Result.BORDER_DOWN_STRICKE;

                if (p.X >= Config.Width || p.X < 0 || p.Y < 0)
                    return Result.BORDER_STRICKE;

                if (Config.CheckStrike(p))
                    return Result.HEAP_STRICKE;
            }
            return Result.SUCCESS;
        }



        public void Move(Action dir)
        {
            foreach (var item in Points)
            {
                item.Move(dir);
            }
        }

        public void Hide()
        {
            //Thread.Sleep(500);
            foreach (var item in Points)
            {
                item.Hide();
            }

        }

        internal bool IsOnTop()
        {
            return Points[0].Y == 0;
        }
    }
}
