﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Tetris
{

    static class Config
    {
        private static int _width = 10;
        private static int _height = 15;
        public const int POINTS_COUNT = 4;

        public static int Width
        {
            get
            {
                return _width;
            }
        }

        public static int Height
        {
            get
            {
                return _height;
            }
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

        public static void TryDeleteLines()
        {
            for (int j = 0; j < Height; j++)
            {
                int counter = 0;
                for (int i = 0; i < Width; i++)
                {
                    if (_heap[j][i])
                        counter++;
                }
                if (counter == Width)
                {
                    DeleteLine(j);
                    Redraw();
                }
            }
        }

        private static void Redraw()
        {
            for (int j = 0; j < Height; j++)
            {
                for (int i = 0; i < Width; i++)
                {
                    if (_heap[j][i])
                        DriverProvider.Driver.DrawPoint(i, j);
                    else
                        DriverProvider.Driver.HidePoint(i, j);
                }

            }
        }

        private static void DeleteLine(int line)
        {
            for (int j = line; j >= 0; j--)
            {
                for (int i = 0; i < Width; i++)
                {
                    if (j == 0)
                        _heap[j][i] = false;
                    else
                        _heap[j][i] = _heap[j - 1][i];
                }
            }
        }
    }
}
