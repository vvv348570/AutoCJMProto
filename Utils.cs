using System;

using static AutoCJM.Program;

namespace AutoCJM
{
    internal static class Utils
    {
        public static void ExecCmd(string command)
        {
            switch (command)
            {
                case "практика":
                case "ghfrnbrf":
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
#if DEBUG
                    CWriteLine(" Функции отладки:", ConsoleColor.DarkMagenta);
                    Console.Write("# "); CWrite("Размер", ConsoleColor.DarkMagenta); Console.WriteLine(" - Установить рекомендуемый размер окна для чата");
                    Console.Write("# "); CWrite("Ошибка", ConsoleColor.DarkMagenta); Console.WriteLine(" - Вызвать обычное исключение");
#endif
                    Console.WriteLine("\n Все команды могут быть написаны без учёта регистра");
                    break;
                case "выход":
                case "ds[jl":
                    Environment.Exit(0);
                    break;
#if DEBUG
                case "размер":
                case "hfpvth":
                    if (OperatingSystem.IsWindows())
                    {
                        Console.SetWindowSize(80, 50);
                        Console.WriteLine(" Установлен размер окна 80х50");
                    }
                    else
                    {
                        CWriteLine("! Вы используете операционную систему, отличную от Windows - изменение размера окна невозможно.", ConsoleColor.Red);
                    }

                    break;
#endif
                default:
                    Console.WriteLine("Неизвестная команда");
                    break;
            }
            return;
        }

        public static void Welcome()
        {
            Console.Title = $"AutoCJM {Program.version}";
            Console.Write("Добро пожаловать в AutoCJM версии "); CWriteLine(Program.version, ConsoleColor.Yellow);
            Console.Write("Наберите "); CWrite("Помощь", ConsoleColor.Yellow); Console.WriteLine(" чтобы получить справку");
#if DEBUG
            CWrite("\n! ", ConsoleColor.Red); Console.WriteLine("Вы находитесь в режиме отладки / DEBUG");
            CWrite("! ", ConsoleColor.Red); Console.Write("Весь текст, предназначенный для отладки будет выделен"); CWriteLine(" фиолетовым", ConsoleColor.DarkMagenta);
#endif
            Console.WriteLine();
        }
    }
}