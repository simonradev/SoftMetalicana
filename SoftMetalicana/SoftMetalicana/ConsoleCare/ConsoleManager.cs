namespace SoftMetalicana.ConsoleCare
{
    using System;
    using SoftMetalicana.Constants;

    /// <summary>
    /// This class takes care of the console but does not print and make validatios.
    /// </summary>
    public static class ConsoleManager
    {
        /// <summary>
        /// Sets the initial console size.
        /// </summary>
        public static void SetConsoleSize()
        {
            Console.WindowHeight = ConsoleConstants.ConsoleHeight;
            Console.WindowWidth = ConsoleConstants.ConsoleWidth;

            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth;
        }
    }
}
