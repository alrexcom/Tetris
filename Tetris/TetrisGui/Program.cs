// See https://aka.ms/new-console-template for more information
//https://github.com/Kartavec/Tetris/tree/lesson37/Gui-part-3/Tetris/TetrisGui


using System.Net;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using Tetris;
using Action = Tetris.Action;
using System.Timers;
using System;
using System.Threading;
using Microsoft.SmallBasic.Library;

class Program
{
    static Figure currentFigure;
    static FigureGenerator factory = new FigureGenerator(Config.Width / 2, 0);
 
    const int TIMER_INTERVAL = 500;
    static System.Timers.Timer timer;

    static Object lockObj = new Object();
    static bool gameOver = false;

    static void Main(string[] args)
    {
        DriverProvider.Driver.InitConfig();
          SetTimer();    
        currentFigure = factory.GetNewFigure();
        currentFigure.Draw();
        GraphicsWindow.KeyDown += GraphicsWindow_KeyDown;
    }

    private static void GraphicsWindow_KeyDown()
    {
        Monitor.Enter(lockObj);
        var result = HandleKey(currentFigure, GraphicsWindow.LastKey);
        if (GraphicsWindow.LastKey == "Down")
           gameOver =  ProcessResult(result, ref currentFigure);

        Monitor.Exit(lockObj);
    }

    private static Result HandleKey(Figure f, string key)
    {
        switch (key)
        {
            case "Left":
                return f.TryMove(Action.LEFT);
            case "Right":
                return f.TryMove(Action.RIGHT);
            case "Down":
                return f.TryMove(Action.DOWN);
            case "Space":
                return f.TryRotate();
        }
        return Result.SUCCESS;
    }


private static void SetTimer()
    {
        timer = new System.Timers.Timer(TIMER_INTERVAL);
        timer.Elapsed += OnTimedEvent;
        timer.AutoReset = true;
        timer.Enabled = true;
    }

    private static void OnTimedEvent(object sender, ElapsedEventArgs e)
    {
        Monitor.Enter(lockObj);
        var result = currentFigure.TryMove(Action.DOWN);
        gameOver = ProcessResult(result, ref currentFigure);
        if (gameOver)
            timer.Stop();
        Monitor.Exit(lockObj);
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
                return true;
            }
            else
            {
                currentFigure = factory.GetNewFigure();
                return false;
            }
        }
        else
            return false;
    }



}