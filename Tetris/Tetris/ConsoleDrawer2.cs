using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class ConsoleDrawer2 : IDrawer
    {

        public void DrawPoint(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine("#");
            Console.SetCursorPosition(0, 0);
        }

        public void HidePoint(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(' ');
            Console.SetCursorPosition(0, 0);
        }

        public void WriteGameOver()
        {
            Console.SetCursorPosition(Config.Width / 2, Config.Height / 2);
            Console.WriteLine("К О Н Е Ц  И Г Р Ы");
        }

        public void InitConfig()
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(Config.Width, Config.Height);
            Console.SetBufferSize(Config.Width, Config.Height);
            Console.ForegroundColor = ConsoleColor.Green;
        }
    }
}
