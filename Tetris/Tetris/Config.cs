using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{

    static class Config
    {
        private static int _width = 30;
        private static int _height = 30;
        public const int POINTS_COUNT = 4;

        public static int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
                Show();
            }
        }

        public static int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
                Show();
            }
        }

        public static void Show()
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(_width, _height);
            Console.SetBufferSize(_width, _height);
            //   Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Green;
        }

        private static bool[][] _heap;

        static Config()
        {
            _heap = new bool[Height][];
            for (int i = 0; i < Height; i++)
            {
                _heap[i] = new bool[Width];
            }

        }

        public static void AddFigure(Figure fig)
        {
            foreach (var p in fig.Points)
            {
                _heap[p.Y][p.X] = true;
            }
        }

        //Проверка столкновения фигуры с кучей 
        public static bool CheckStrike(Point p)
        {
            //если столкновения нет то возвращает true
            return _heap[p.Y][p.X];
        }
    }
}
