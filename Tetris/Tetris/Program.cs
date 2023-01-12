// See https://aka.ms/new-console-template for more information
using Tetris;


Console.SetWindowSize(40, 30);
Console.SetBufferSize(40,30);

//Square s = new Square(3, 6, '#');
//s.Draw();

//Stick l = new Stick(8, 10, '*');
//l.Draw();


Figure[] f = new Figure[2];
f[0] = new Square(3, 6, '#');
f[1] = new Stick(8, 10, '*');

foreach (var item in f)
{
    item.Draw();
}



Console.ReadLine(); 