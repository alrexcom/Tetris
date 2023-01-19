using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace Tetris
{
    public class GuiDriver : IDrawer
    {
        public const int SIZE = 20;

        public void DrawPoint(int x, int y)
        {
            // GraphicsWindow.PenColor = GraphicsWindow.GetRandomColor(); 
            //GraphicsWindow.PenWidth = 2;
            GraphicsWindow.BrushColor = GraphicsWindow.GetRandomColor();
            // GraphicsWindow.DrawRectangle(x * SIZE, y * SIZE, SIZE, SIZE);
            GraphicsWindow.FillRectangle(x * SIZE, y * SIZE, SIZE, SIZE);


        }

        public void HidePoint(int x, int y)
        {
            // GraphicsWindow.PenColor = GraphicsWindow.BackgroundColor;
            //  GraphicsWindow.PenWidth = 4;
            GraphicsWindow.BrushColor = GraphicsWindow.BackgroundColor;
            // GraphicsWindow.DrawRectangle(x * SIZE, y * SIZE, SIZE, SIZE);
            GraphicsWindow.FillRectangle(x * SIZE, y * SIZE, SIZE, SIZE);
        }

        public void WriteGameOver()
        {
            GraphicsWindow.FontSize = SIZE;
            GraphicsWindow.BrushColor = GraphicsWindow.GetRandomColor();
            GraphicsWindow.DrawText((Config.Width / 2 - 4) * SIZE, (Config.Height / 2) * SIZE, "К О Н Е Ц \n И Г Р Ы");
   
        }

        public void InitConfig()
        {
            GraphicsWindow.Title = "Тетрис";
            GraphicsWindow.Width = Config.Width * SIZE;
            GraphicsWindow.Height = Config.Height * SIZE;
            GraphicsWindow.BackgroundColor = "LightBlue";
            GraphicsWindow.Show();

        }
    }
}
