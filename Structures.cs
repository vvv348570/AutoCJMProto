using System;

namespace AutoCJM
{
    /// <summary>
    /// ������ "�����" CJM
    /// </summary>
    internal class Map
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
            for (int i = 1; input.Equals("�Ѩ") == false; i++)
            {
                input = Console.ReadLine();
                input = input.ToUpper();
                Console.Write("��������� ��� ���� ������?(��� ������ ������, ��� ����)");
                rating = Convert.ToInt32(Console.ReadLine());
                Csvutils.Write(csmap, input, i, 1 + rating);
            }
            return csmap;
        }

        public static void WriteFile(Map csmap, string name)
        {
            // csmap ������������ � csv ����
        }
    }
}