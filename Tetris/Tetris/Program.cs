// See https://aka.ms/new-console-template for more information
using System.Net;
using Tetris;
using Action = Tetris.Action;

Console.SetWindowSize(40, 30);
Console.SetBufferSize(40,30);








for (int i = 0; i < 10; i++)
{
    FigureGenerator generator = new FigureGenerator(15, 2, '+');
    Figure l = generator.GetNewFigure();
    l.Draw();
    l.Move(Action.right);
    for (int k = 0; k < 15; k++)
    {
        if(k%2 == 0)
        l.Move(Action.down);
        else
        {
            l.Hide();
            l.Rotate();
            l.Draw();
        }        
    }
    l.Hide();
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




//Figure[] f = new Figure[2];
//f[0] = new Square(3, 6, '#');
//f[1] = new Stick(8, 10, '*');

//foreach (var item in f)
//{
//    item.Draw();
//}



Console.ReadLine(); 