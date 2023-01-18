// See https://aka.ms/new-console-template for more information
using System.Net;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using Tetris;
using Action = Tetris.Action;
using System.Timers;
using System.ComponentModel.DataAnnotations;

class Program
{
    static Figure currentFigure;
    static FigureGenerator generator;

    const int TIMER_INTERVAL = 500;
    static System.Timers.Timer timer;

    static private Object _lock_object = new Object();

    static void Main(string[] args)
    {

        DriverProvider.Driver.InitConfig();

        generator = new FigureGenerator(Config.Width / 2, 0);
        currentFigure = generator.GetNewFigure();
        SetTimer();

        while (true)
        {
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey();
                Monitor.Enter(_lock_object);
                var result = HandleKey(currentFigure, key);
                ProcessResult(result, ref currentFigure);
                Monitor.Exit(_lock_object);
            }
        }
    }

    private static void SetTimer()
    {
        timer = new System.Timers.Timer(TIMER_INTERVAL);
        timer.Elapsed += OnTimedEvent;
        timer.AutoReset = true;
        timer.Enabled = true;
    }

    private static void OnTimedEvent(object? sender, ElapsedEventArgs e)
    {
        Monitor.Enter(_lock_object);
        var result = currentFigure.TryMove(Action.DOWN);
        ProcessResult(result, ref currentFigure);
        Monitor.Exit(_lock_object);
    }

    private static bool ProcessResult(Result result, ref Figure currentFigure)
    {
        if (result == Result.HEAP_STRICKE || result == Result.BORDER_DOWN_STRICKE)
        {
            Config.AddFigure(currentFigure);
            Config.TryDeleteLines();
            if (currentFigure.IsOnTop())
            {
                DriverProvider.Driver.WriteGameOver();
                timer.Elapsed -= OnTimedEvent;
                return true;
            }
            else
            {

                currentFigure = generator.GetNewFigure();
                return true;
            }
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
