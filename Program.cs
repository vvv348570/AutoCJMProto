using System;

namespace AutoCJM
{
    internal class Program
    {
        public static string version = "Proto-0.4";

        /// <summary>
        /// Входная точка программы
        /// </summary>
        public static void Main()
        {
            Console.Title = $"AutoCJM {version}";
            Console.Write("Добро пожаловать в AutoCJM версии "); CWriteLine(version, ConsoleColor.Yellow);
            Console.Write("Наберите "); CWrite("Помощь", ConsoleColor.Yellow); Console.WriteLine(" чтобы получить справку");
            Console.WriteLine();
            while (true)
            {
                try
                {
                    Utils.ExecCmd(CRead().ToLower());
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
        /// Вывод текста (или объекта) в консоль с определённым цветом и добавлением новой строки в конец
        /// </summary>
        /// <param name="obj">Объект вывода</param>
        /// <param name="color">Цвет вывода</param>
        public static void CWriteLine(object obj, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(obj.ToString());
            Console.ResetColor();
        }

        /// <summary>
        /// Приглашение ввода с зелёным символом '>' в начале строки
        /// </summary>
        /// <returns>Полученную строку</returns>
        public static string CRead()
        {
            string input = "";
            while (string.IsNullOrWhiteSpace(input)) // не даст вернуть пустой ввод и спросит ещё разок
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("> ");
                Console.ResetColor();
                input = Console.ReadLine().Trim();
            }
            return input;
        }
    }
}