﻿// See https://aka.ms/new-console-template for more information
using System.Net;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using Tetris;
using Action = Tetris.Action;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.SetWindowSize(Config.WIDTH, Config.HEIGHT);
        Console.SetBufferSize(Config.WIDTH, Config.HEIGHT);
        Console.CursorVisible = false;

        FigureGenerator generator = new FigureGenerator(15, 2, '*');
        Figure currentFigure = generator.GetNewFigure();

        while (true)
        {
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey();
                HandleKey(currentFigure, key);
            }
        }
    }
    private static void HandleKey(Figure currentFigure, ConsoleKeyInfo key)
    {
        switch (key.Key)
        {
            case ConsoleKey.LeftArrow:
                currentFigure.TryMove(Action.left);
                break;
            case ConsoleKey.RightArrow:
                currentFigure.TryMove(Action.right);
                break;
            case ConsoleKey.DownArrow:
                currentFigure.TryMove(Action.down);
                break;
            case ConsoleKey.Spacebar:
                currentFigure.Rotate();
                break;
        }
    }
}
