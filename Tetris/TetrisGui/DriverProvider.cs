namespace Tetris
{
    static class DriverProvider
    {
        private static IDrawer _drawer = new GuiDriver();

        public static IDrawer Driver { get { return _drawer; } }
    }
}
