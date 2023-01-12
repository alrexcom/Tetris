// See https://aka.ms/new-console-template for more information


using Tetris;

//Console.SetWindowSize(40, 30);
//Console.SetBufferSize(40, 30);


//    Point[] points = new Point[6];
//    points[0] = new Point(2, 5, '*');
//    points[1] = new Point(4, 2, '%');
//    points[2] = new Point(6, 10, '#');
//    points[3] = new Point(12, 15, '(');
//    points[4] = new Point(9, 13, '-');
//    points[5] = new Point(3, 18, '@');

//foreach (var item in points)
//{
//    item.Draw();
//}


char[][] field = new char[3][];
field[0] = new char[3];
field[1] = new char[3];
field[2] = new char[3];

field[0][0] = 'X';
field[2][2] = '0';

for (int i = 0; i < field.Length; i++)
{
	for (int k = 0; k < field[i].Length; k++)
	{
		Console.WriteLine(field[i][k]);
	}
	Console.WriteLine();
}             

Console.ReadLine();
