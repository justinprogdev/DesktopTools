namespace WinMonitor.View
{
    public static class Print
    {
        public static void ProcessPrint(string value)
        {

            string prefix = string.Empty;
            string[] line = value.Split("**#**", 2 ,StringSplitOptions.TrimEntries);
            if (line.Length == 2)
            {
                prefix = line[0].ToLower();
                value = line[1];
            }

            switch (prefix)
            {
                case "loggerinfo":
                    Blue(value);
                    break;

                case "loggererror":
                    Red(value);
                    break;

                case "loggerevent":
                    Yellow(value);
                    break;
                case "flursh":
                    Clear();
                    break;

                default:
                    Gray(value);
                    break;
            }
        }

        private static void Clear()
        {
            Console.Clear();
        }

        private static void Yellow(string value)
        {
            Color.Yellow();
            Console.WriteLine(value);
            Color.Reset();
        }

        private static void Gray(string value)
        {
            Console.WriteLine(value);
        }
        /// <summary>
        /// Prints text in the color blue
        /// </summary>
        /// <param name="value"></param>
        public static void Blue(string value)
        {
            Color.Cyan();
            Console.WriteLine(value);
            Color.Reset();
        }

        /// <summary>
        /// Prints text in the color red
        /// </summary>
        /// <param name="value"></param>
        private static void Red(string value)
        {
            Color.Red();
            Console.WriteLine(value);
            Color.Reset();
        }
    }
}