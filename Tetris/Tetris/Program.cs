// See https://aka.ms/new-console-template for more information
using System.Net;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using Tetris;
using Action = Tetris.Action;


internal class Program
{
    static FigureGenerator generator = null;
    static void Main(string[] args)
    {

        Config.Show();
        /* 
               Console.SetWindowSize(Config.Width, Config.Height);
               Console.SetBufferSize(Config.Width, Config.Height);
               Console.CursorVisible = false;

                Config.Width = 20;
                Config.Height = 20; 13.2. Разбор дз 5:52
               */

        // FigureGenerator generator = new FigureGenerator(Config.Width / 2, 0, '*');
        generator = new FigureGenerator(Config.Width / 2, 0, Drawer.DEFAULT_SYMBOL);
        Figure currentFigure = generator.GetNewFigure();

        while (true)
        {
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey();
                var result = HandleKey(currentFigure, key);
                ProcessResult(result, ref currentFigure);
            }
        }
    }

    private static bool ProcessResult(Result result, ref Figure currentFigure)
    {
        if (result == Result.HEAP_STRICKE || result == Result.BORDER_DOWN_STRICKE)
        {
            Config.AddFigure(currentFigure);
            Config.TryDeleteLines();
            currentFigure = generator.GetNewFigure();
            return true;
        }
        else
            return false;
    }

    private static Result HandleKey(Figure f, ConsoleKeyInfo key)
    {


        switch (key.Key)
        {
            case ConsoleKey.LeftArrow:
                return f.TryMove(Action.LEFT);
            case ConsoleKey.RightArrow:
                return f.TryMove(Action.RIGHT);
            case ConsoleKey.DownArrow:
                return f.TryMove(Action.DOWN);
            case ConsoleKey.Spacebar:
                return f.TryRotate();
        }
        return Result.SUCCESS;
    }
}
