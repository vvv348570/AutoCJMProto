using System;

namespace AutoCJM
{
    internal static class Csvutils
    {
        public static void Write(Map csmap, string value, int x, int y)
        {

            return;
        }

        public static Map TellStory()
        {
            string input = "";
            int rating;
            Map csmap = new();
            Csvutils.Write(csmap, "+", 0, 0);
            for (int i = 1; input.Equals("ВСЁ") == false; i++)
            {
                input = Console.ReadLine();
                input = input.ToUpper();
                Console.Write("Насколько оно было плохим?(Чем больше баллов, тем хуже)");
                rating = Convert.ToInt32(Console.ReadLine());
                Csvutils.Write(csmap, input, i, 1 + rating);
            }
            return csmap;
        }

        public static void WriteFile(Map csmap, string name)
        {
            // csmap записывается в csv файл
        }
    }
}