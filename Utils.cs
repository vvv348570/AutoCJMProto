using System;

namespace AutoCJM
{
    internal static class Utils
    {
        public static void ExecCmd(string str)
        {
            switch (str)
            {
                case "практика":
                    Functions.Practice();
                    break;

                case "теория":
                    Functions.Theory();
                    break;

                case "помощь":
                    Console.WriteLine("Некоторые команды:");
                    Console.WriteLine("\"Помощь\": посмотреть эту справку");
                    Console.WriteLine("\"Теория\": просмотреть теорию по CJM");
                    Console.WriteLine("\"Практика\": начать практику");
                    Console.WriteLine("\"Выход\": выйти из программы");
                    break;

                default:
                    Console.WriteLine("Неизвестная команда");
                    break;
            }
            return;
        }
        public static void Welcome()
        {
            Console.WriteLine("Добро пожаловать в AutoCjm версии {0}", Program.Version);
            Console.WriteLine("Наберите \"Помощь\", чтобы посмотреть справку");
        }
    }
}