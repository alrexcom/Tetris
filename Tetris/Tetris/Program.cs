// See https://aka.ms/new-console-template for more information
using Tetris;


Console.SetWindowSize(40, 30);
Console.SetBufferSize(40,30);

Tetris.Point p1 = new (2,3,'#');

p1.Draw();


Tetris.Point p2 = new(20, 10, '*');

p2.Draw();

Console.ReadLine(); 