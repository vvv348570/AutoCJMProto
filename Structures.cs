using System.Collections.Generic;
using System.IO;

namespace AutoCJM
{
    /// <summary>
    /// ������ "�����" CJM
    /// </summary>
    internal class Map
    {
        /// <summary>
        /// �������� � ���� ���������� �������
        /// </summary>
        private List<List<string>> plainMap = new()
        {
            { new() { "������: 5 - �������" } },
            { new() { "������: 4 - ������" } },
            { new() { "������: 3 - ������" } },
            { new() { "������: 2 - �����" } },
            { new() { "������: 1 - ������" } },
            { new() { " " } }, // ��� ������� ������������ ��� �������� �����, ������� ��� ������
        };

        public void AddStep(string upText, string downText, int rating)
        {
            for (int i = 0; i <= 4; i++)
            {
                if (i == 5 - rating)
                {
                    plainMap[5 - rating].Add(upText);
                }
                else
                {
                    plainMap[i].Add("");
                }
            }
            plainMap[5].Add(downText);
        }

        /// <summary>
        /// ���������� CSV ����� �� ������ CJM � ���������� ��� � ����
        /// </summary>
        /// <param name="name">�������� �����</param>
        public void Build(string name = "CJM.csv")
        {
            using StreamWriter file = new(name, false, encoding: System.Text.Encoding.UTF8);
            for (int i = 0; i < plainMap.Count; i++)
            {
                for (int j = 0; j < plainMap[i].Count; j++)
                {
                    file.Write(plainMap[i][j]);
                    file.Write(";");
                }
                file.Write("\n");
            }
            file.Flush();
        }
    }
}