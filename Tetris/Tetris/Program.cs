// See https://aka.ms/new-console-template for more information
Console.SetWindowSize(40, 30);
Console.SetBufferSize(40,30);


Draw(2, 3, '*');
Draw(5, 10, '#');

Console.ReadLine();      

static void Draw(int x, int y, char c)
{
    Console.SetCursorPosition(x, y);
    Console.WriteLine(c);
}
