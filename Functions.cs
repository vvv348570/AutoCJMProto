using System;

namespace AutoCJM
{
    internal static class Functions
    {
        /// <summary>
        /// Вывод теории на экран
        /// </summary>
        public static void Theory()
        {
            Program.CWriteLine("Теория составления будет добавлена в будущем", ConsoleColor.Cyan);
        }

        /// <summary>
        /// Выполнение тестового составления CJM
        /// </summary>
        public static void Practice()
        {
            Console.Clear();
            Console.WriteLine("Привет! ");
        }
    }
}