using System;
using System.IO;
using System.Linq;
using System.Text;

using static AutoCJM.Program;

namespace AutoCJM
{
    /// <summary>
    /// Утилиты, предназначенные для вывода текста и других функций
    /// </summary>
    internal static class Utils
    {
        /// <summary>
        /// Выполнение команды, полученной в главном цикле
        /// </summary>
        /// <param name="command">Имя команды</param>
        public static void ExecCmd(string command)
        {
            switch (command)
            {
                case "практика":
                case "ghfrnbrf": // специально для меня, который вечно путается в раскладках
                    Functions.Practice();
                    break;

                case "теория":
                case "ntjhbz":
                    Functions.Theory();
                    break;

                case "помощь":
                case "gjvjom":
                    Console.WriteLine(" Доступные команды: ");
                    Console.Write("# "); CWrite("Теория", ConsoleColor.Yellow); Console.WriteLine(" - Немного теории о Custom Journey Map");
                    Console.Write("# "); CWrite("Практика", ConsoleColor.Yellow); Console.WriteLine(" - Тест создания CJM");
                    Console.Write("# "); CWrite("Помощь", ConsoleColor.Yellow); Console.WriteLine(" - Вывести эту справку");
                    Console.Write("# "); CWrite("Выход", ConsoleColor.Yellow); Console.WriteLine(" - Закрыть программу");
                    Console.WriteLine("\n Все команды могут быть написаны без учёта регистра");
                    break;
                case "выход":
                case "ds[jl":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Неизвестная команда");
                    break;
            }
            return;
        }


    }
}