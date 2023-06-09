namespace WinMonitor
{
    public static class Color
    {

        public static void Cyan()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
        }

        public static void Red()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
        }

        public static void Reset()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        internal static void Yellow()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
    }
}