// See https://aka.ms/new-console-template for more information
using System.Net;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using Tetris;
using Action = Tetris.Action;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.SetWindowSize(40, 30);
        Console.SetBufferSize(40, 30);

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
                currentFigure.Move(Action.left);
                break;
            case ConsoleKey.RightArrow:
                currentFigure.Move(Action.right);
                break;
            case ConsoleKey.DownArrow:
                currentFigure.Move(Action.down);
                break;
            case ConsoleKey.W:
                currentFigure.Rotate();
                break;
        }
    }
}
/*Figure s;

while(true)
{
    FigureFall(out s, generator);
    s.Draw();
    s.Move(Action.right);
    s.Draw();
}
  

static void FigureFall( out Figure fig, FigureGenerator gen)
{
    fig = gen.GetNewFigure();
    fig.Draw();
    for (int k = 0; k < 15; k++)
    {
        fig.Move(Action.down);
        Thread.Sleep(200);
    }
    fig.Hide();
}



l.Draw();
s.Draw();
l.Move(Action.left);

l.Move(Action.down);
l.Move(Action.right);
l.Move(Action.right);
l.Hide();
l.Rotate();
l.Draw();
l.Move(Action.down);
l.Move(Action.down);
l.Move(Action.down);
l.Move(Action.right);
l.Move(Action.right);
l.Move(Action.left);
l.Move(Action.down);
l.Hide();
l.Rotate();
l.Draw();





s.Move(Action.down);
s.Move(Action.right);
s.Move(Action.right);
s.Move(Action.down);
s.Move(Action.down);
s.Move(Action.down);
s.Move(Action.right);
s.Move(Action.right);
s.Move(Action.left);
s.Move(Action.down);

*/

