using System;

namespace AutoCJM
{
    internal class Program
    {
        public static string Version = "0.1";

        public static void Main()
        {
            Utils.Welcome();
            string input;
            while (true)
            {
                try
                {
                    Console.Write("> ");
                    input = Console.ReadLine();
                    input = input.ToLower();

                    if (input.Equals("выход"))
                    {
                        break;
                    }
                    else
                    {
                        Utils.ExecCmd(input);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"! Возникла ошибка: {e.Message}");
                }
            }
            return;
        }
    }
}