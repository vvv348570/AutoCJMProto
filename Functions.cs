using System;

using static AutoCJM.Program;

namespace AutoCJM
{
    internal static class Functions
    {
        /// <summary>
        /// Теория большого взрыва
        /// </summary>
        public static void Theory()
        {
            CWriteLine("Составление теории CJM ещё в разработке\nИспользуйте [Практика]", ConsoleColor.Cyan);
        }

        /// <summary>
        /// Выполнение тестового составления CJM
        /// </summary>
        public static void Practice()
        {

#pragma warning disable IDE0059 // Отключение рекомендации "Удалить избыточные операторы объявления"
            string upText = "";
            string downText = "";
            int rating = 0;
#pragma warning restore IDE0059 // Возвращение рекомендации "Удалить избыточные операторы объявления"

            // Немного приготовлений
            Console.Clear();
            if (OperatingSystem.IsWindows())
            {
                Console.SetWindowSize(80, 40);
            }
            Map cjm = new();

            // Даём имя CJM
            Console.Title = $"Новый файл | AutoCJM {version}";
            Console.WriteLine("Привет! Эта интеративная консоль поможет тебе в составлении CJM");
            Console.WriteLine("Как будет называться этот CJM? Например, \"Мой день\"");
            string name = CRead();
            Console.WriteLine($"Ок! Делаем CJM \"{name}\"!");
            Console.Title = $"{name} | AutoCJM {version}"; // И немного изменим заголовок консоли

        // Разбор первого шага - Описание
        FirstStep:
            Console.WriteLine("С чего все началось? Какой был первый шаг?");
            upText = CRead();

            // Разбор первого шага - Оценка 
            Console.WriteLine($"Каким было твоё настроение от 1 до 5 в этот момент?\nГде 5 - Отлично, а 1 - Ужасно");
            while (true)
            {
                try
                {
                    rating = int.Parse(CRead());
                }
                catch (FormatException)
                {
                    CWriteLine("Ввести нужно только число! (в цифровом формате, например \"4\")", ConsoleColor.Yellow);
                    continue;
                }
                if (rating < 1 || rating > 5)
                {
                    CWriteLine("Это число не лежит в диапазоне [1 - 5]", ConsoleColor.Yellow);
                    continue;
                }
                break;
            }
            // Разбор первого шага - Причина 
            Console.WriteLine($"Теперь можешь описать причину, почему твоё настроение было именно таким");
            downText = CRead();

            // У нас есть первый шаг - покажем и добавим его
            Console.WriteLine($"Вот твой первый шаг на CJM {name}:");
            Console.WriteLine($"Шаг: {upText}");
            Console.WriteLine($"Настроение на шаге: {rating}/5 [{StrRating(rating)}]");
            Console.WriteLine($"Причина настроения: {downText}");
            Console.WriteLine($"Добавляем его? [да/нет] или [д/н]");
            string resp = CRead();
            if (resp == "нет" || resp == "н")
            {
                goto FirstStep;
            }

            cjm.AddStep(upText, downText, rating);

            // Все поледующие шаги используют одни и те же фразы, поэтому я кладу их в цикл
            while (true)
            {
                // Шаг
                Console.WriteLine("Каким был следующий шаг этого путешествия?");
                upText = CRead();

                // Оценка
                Console.WriteLine($"Каким было твоё настроение от 1 до 5 в этот момент?\nГде 5 - Отлично, а 1 - Ужасно");
                while (true) 
                {
                    try
                    {
                        rating = int.Parse(CRead());
                    }
                    catch (FormatException)
                    {
                        CWriteLine("Ввести нужно только число! (в цифровом формате, например \"4\")", ConsoleColor.Yellow);
                        continue;
                    }
                    if (rating < 1 || rating > 5)
                    {
                        CWriteLine("Это число не лежит в диапазоне [1 - 5]", ConsoleColor.Yellow);
                        continue;
                    }
                    break;
                }
                // Причина 
                Console.WriteLine($"Теперь можешь описать причину, почему твоё настроение было именно таким");
                downText = CRead();

                // Опрос и добавление
                Console.WriteLine($"Вот твой первый шаг на CJM {name}:");
                Console.WriteLine($"Шаг: {upText}");
                Console.WriteLine($"Настроение на шаге: {rating}/5 [{StrRating(rating)}]");
                Console.WriteLine($"Причина настроения: {downText}");
                Console.WriteLine($"Добавляем его? [да/нет] или [д/н]");

            AddLine:
                resp = CRead();
                if (resp == "нет" || resp == "н")
                {
                    continue;
                }

                if (resp != "да" && resp != "д")
                {
                    goto AddLine;
                }
                cjm.AddStep(upText, downText, rating);


                Console.WriteLine($"Приступаем к следующему шагу? [да/нет] или [д/н]");
            NextStep:
                resp = CRead();
                if (resp == "нет" || resp == "н")
                {
                    break;
                }

                if (resp != "да" && resp != "д")
                {
                    goto NextStep;
                }
            }


            // И только теперь мы сохраняем это в csv-файл
            cjm.Build();

            CWriteLine("\n\nCJM был сохранён в файл [CJM.csv] в папке с программой", ConsoleColor.Cyan);
        }

        /// <summary>
        /// Бесполезная функция для преобразования числа в строку
        /// </summary>
        /// <returns>Строку</returns>
        public static string StrRating(int rating)
        {
            // В теории можно было сделать словать таких значений, но такое будет нечитабельно
            if (rating == 1)
            {
                return "Ужасно";
            }

            if (rating == 2)
            {
                return "Плохо";
            }

            if (rating == 3)
            {
                return "Нормально";
            }

            if (rating == 4)
            {
                return "Хорошо";
            }

            if (rating == 5)
            {
                return "Отлично";
            }

            return "";
        }
    }
}