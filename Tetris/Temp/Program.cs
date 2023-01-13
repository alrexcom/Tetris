
// See https://aka.ms/new-console-template for more information

Random rnd = new Random();
//int k = rnd.Next(0, 5);

for (int i = 0; i < 20; i++)
{
    Console.WriteLine(rnd.Next(0, i));
}


