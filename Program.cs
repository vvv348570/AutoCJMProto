using System;

namespace AutoCJM
{
    internal class Program
    {
        public static string version = "Proto-0.3";

        /// <summary>
        /// Входная точка программы
        /// </summary>
        public static void Main()
        {
            Utils.Welcome();
            string input;
            while (true)
            {
                try
                {
                    CWrite("> ", ConsoleColor.Green);
                    input = Console.ReadLine();
                    input = input.ToLower();
                    Utils.ExecCmd(input);
                }
                catch (Exception e)
                {
                    CWriteLine($"! Возникла ошибка: {e.Message}", ConsoleColor.DarkRed);
                }
            }
        }

        /// <summary>
        /// Вывод текста (или объекта) в консоль с определённым цветом
        /// </summary>
        /// <param name="obj">Объект вывода</param>
        /// <param name="color">Цвет вывода</param>
        public static void CWrite(object obj, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(obj.ToString());
            Console.ResetColor();
        }

        /// <summary>
        /// Вывод текста (или объекта) в консоль с определённым цветом и добавлением новой строки
        /// </summary>
        /// <param name="obj">Объект вывода</param>
        /// <param name="color">Цвет вывода</param>
        public static void CWriteLine(object obj, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(obj.ToString());
            Console.ResetColor();
        }
    }
}