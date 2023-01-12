// See https://aka.ms/new-console-template for more information
using System.Drawing;

Console.SetWindowSize(40, 30);
Console.SetBufferSize(40,30);

Tetris.Point p1 = new Tetris.Point();
p1.x = 2; p1.y = 3;
p1.c = '*';

p1.Draw();


Console.ReadLine(); 