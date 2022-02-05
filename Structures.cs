using System.Collections.Generic;
using System.IO;

namespace AutoCJM
{
    /// <summary>
    /// Объект "карты" CJM
    /// </summary>
    internal class Map
    {
        /// <summary>
        /// Табличка в виде двумерного массива
        /// </summary>
        private List<List<string>> plainMap = new()
        {
            { new() { "Эмоции: 5 - Отлично" } },
            { new() { "Эмоции: 4 - Хорошо" } },
            { new() { "Эмоции: 3 - Средне" } },
            { new() { "Эмоции: 2 - Плохо" } },
            { new() { "Эмоции: 1 - Ужасно" } },
            { new() { " " } }, // Эта строчка используется для описания шагов, поэтому без эмоции
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
        /// Генерирует CSV карту на основе CJM и записывает это в файл
        /// </summary>
        /// <param name="name">Название файла</param>
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