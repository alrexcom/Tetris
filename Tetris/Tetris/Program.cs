// See https://aka.ms/new-console-template for more information
using System.Net;
using Tetris;
using Action = Tetris.Action;

Console.SetWindowSize(40, 30);
Console.SetBufferSize(40,30);

FigureGenerator generator = new FigureGenerator(15, 2, '*');
Figure s;

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
/*


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

