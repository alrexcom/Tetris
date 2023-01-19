// See https://aka.ms/new-console-template for more information
using System;
using Tetris;

internal class FigureGenerator
{
    private int _x;
    private int _y;  
    Random rnd = new Random();
    public FigureGenerator(int x, int y)
    {
        _x = x; _y = y; 
    }

    public Figure GetNewFigure()
    {

        if (rnd.Next(0, 2) == 0)
            return new Square(_x, _y);
        else
            return new Stick(_x, _y);

    }
}