using System;

namespace AutoCJM
{
    internal static class Functions
    {
        public static void Theory()
        {
            string input;
            while (true)
            { // вместо этой тупой, ущербной функции можно было бы спокойно запилить свой некий формат файлов сбиш для теории, но я не знаю как это сделать на C#
                Console.WriteLine("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed consequat, purus vitae interdum lacinia, erat eros dapibus neque, et malesuada purus justo quis magna. Sed neque libero, tempor sed dolor ac, vulputate porttitor magna. Aenean mollis, nisl quis egestas tincidunt, leo sem viverra velit, sed tristique nibh leo eget eros. Mauris dictum ultricies tortor et tempus. Curabitur at feugiat justo. Nullam id augue eu metus blandit hendrerit id eget risus. Cras a fermentum ante. Maecenas urna sapien, tincidunt non hendrerit quis, porttitor eget massa.");
                Console.Write("2 + 2 = ");
                input = Console.ReadLine();
                if (!input.Equals("4"))
                {
                    continue;
                }

                Console.WriteLine("Integer dictum sed augue quis placerat. Vivamus tincidunt, lectus vel consequat fringilla, nulla libero pharetra leo, a faucibus ex tellus id erat. Fusce tellus ligula, facilisis et nibh ut, ultricies commodo arcu. Aliquam dignissim eu ante non finibus. In ullamcorper erat eu eros auctor fermentum. Aliquam porta est dui, ultricies gravida sem commodo sed. Morbi tempus nec neque nec interdum. Nullam sed sapien ut purus maximus aliquam ac at mi. Nullam enim metus, suscipit a tortor pharetra, euismod rhoncus sem. Curabitur id velit vel massa ullamcorper molestie. Donec eu porttitor purus. Maecenas nunc felis, interdum vitae ipsum vel, sollicitudin fermentum massa. Donec vitae sem eu purus egestas finibus. Etiam mollis sapien vitae interdum convallis. Aliquam non velit mauris. Sed fermentum, dolor a molestie volutpat, dui tellus pretium nulla, sit amet tempus dolor velit nec magna.");
                Console.Write("lg100 = ");
                input = Console.ReadLine();
                if (!input.Equals("2"))
                {
                    continue;
                }

                // создаём csvшку
                Csvmap csmap = Csvutils.TellStory();
                break;
            }
            Console.WriteLine("Готово");
            return;
        }

        public static void Practice()
        {
            string input = "";
            Console.WriteLine("С чего начнём?\n1.Составить CJM с помощью, как это было в \"теории\"\n2.Составить CJM самостоятельно");
            while (input != "1" && input != "2")
            {
                input = Console.ReadLine();
            }
        }
    }
}