namespace Tetris
{
    static class DriverProvider
    {
        private static IDrawer _drawer = new ConsoleDrawer();

        public static IDrawer Driver { get { return _drawer; } }
    }
}
