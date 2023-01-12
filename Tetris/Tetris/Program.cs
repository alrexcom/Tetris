// See https://aka.ms/new-console-template for more information
using Tetris;
using Action = Tetris.Action;

Console.SetWindowSize(40, 30);
Console.SetBufferSize(40,30);

//Stick l = new Stick(8, 10, '*');
Square l = new Square(8, 10, '#');
l.Draw();
 
l.Move(Action.left);

l.Move(Action.down);
l.Move(Action.right);
l.Move(Action.right);
l.Move(Action.down);
l.Move(Action.down);
l.Move(Action.down);
l.Move(Action.down);
l.Move(Action.down);
//l.Draw();
//Figure[] f = new Figure[2];
//f[0] = new Square(3, 6, '#');
//f[1] = new Stick(8, 10, '*');

//foreach (var item in f)
//{
//    item.Draw();
//}



Console.ReadLine(); 