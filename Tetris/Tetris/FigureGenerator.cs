﻿// See https://aka.ms/new-console-template for more information
using Tetris;

internal class FigureGenerator
{
    private int _x; private int _y;
    private char _symb ;
    Random rnd = new Random();
    public FigureGenerator(int x, int y,char symb)
    {
        _x = x; _y = y; _symb = symb;
    }

    public Figure GetNewFigure()
    {
        if (rnd.Next(0, 2) == 0)
            return new Square(_x, _y, _symb);
        else
            return new Stick(_x, _y, _symb);
        
    }
}