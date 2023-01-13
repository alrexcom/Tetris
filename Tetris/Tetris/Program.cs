// See https://aka.ms/new-console-template for more information
using System.Net;
using Tetris;
using Action = Tetris.Action;

Console.SetWindowSize(40, 30);
Console.SetBufferSize(40,30);

Figure l = new Stick(8, 10, '=');
//Figure l = new Square(8, 10, '#');
l.Draw();
 
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
//Figure[] f = new Figure[2];
//f[0] = new Square(3, 6, '#');
//f[1] = new Stick(8, 10, '*');

//foreach (var item in f)
//{
//    item.Draw();
//}



Console.ReadLine(); 