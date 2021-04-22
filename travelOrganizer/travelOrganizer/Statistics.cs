using System;
using System.Collections.Generic;

namespace travelOrganizer
{
    class Statistics
    {
        static public string[] MenuStatisticsString =
        {
             "1 - Статистика по путешествиям",
             "2 - Записать сколько км. проехал в путешествии",
             "3 - Записать сколько часов провел в путешествии",
             "4 - Записать сколько потратил денег в путешествии",
             "5 - Вернуться в основное меню",
        };
        static public void PrintMenuStatistics()
        {
            Console.Clear();
            foreach (var menuStatistics in MenuStatisticsString)
            {
                Console.WriteLine(menuStatistics);
            }
            Console.WriteLine("Нажмите цифру, соответствующую номеру меню.");
        }
        static public string[] ListStatistics =
        {
            "1 - Вывести статистику по каждому путешествию отдельно",
            "2 - Вывести общую статистику",
            "3 - Вывести среднюю статистику",
            "4 - Вернуться в меню статистики",
        };
        static public void PrintListStatistics()
        {
            Console.Clear();
            foreach (var listStatistics in ListStatistics)
            {
                Console.WriteLine(listStatistics);
            }
            Console.WriteLine("Нажмите цифру, соответствующую номеру меню.");
        }
        public static void MenuStatistics()
        {
            ConsoleKey key = ConsoleKey.Enter;
            do
            {
                PrintMenuStatistics();
                key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.D1:
                        Travel.AddDistance();
                        break;
                    case ConsoleKey.D1:
                        Travel.AddDistance();
                        break;
                    default: continue;
                }
            } while (key != ConsoleKey.D3);
            Console.WriteLine("Удачи!");
        }
    }
    class Travel
    {
        public static List<Travel> Travels { get; set; } = new List<Travel>();
        public static double Distance { get; set; }
        public double Time { get; set; }
        public double Money { get; set; }
        public Travel(Journey Journeys, double distance, double time, double money)
        {
            Distance = distance;
            Time = time;
            Money = money;
            Travels.Add(this);
        }
        public override string ToString()
        {
            return string.Format("{0};{1};{2}", Distance, Time, Money);
        }
        public static void AddDistance()
        {
            Console.Clear();
            Console.Write("Введите растояние пройденное в путешествии: ");
            double distance;
            while (!double.TryParse(Console.ReadLine(), out distance))
            {
                Console.Write("Попробуйте снова ввести растояние: ");
            }
            Distance = distance;
            Console.WriteLine("Для перехода в меню нажмите любую клавишу...");
            Console.ReadKey();
        }
        public void AddTime(Travel travel)
        {
            Console.Clear();
            Console.Write("Введите время проведенное в путешествии: ");
            double time;
            while (!double.TryParse(Console.ReadLine(), out time))
            {
                Console.Write("Попробуйте снова ввести время: ");
            }
            travel.Time = time;
            Console.WriteLine("Для перехода в меню нажмите любую клавишу...");
            Console.ReadKey();
        }
        public void AddMoney(Travel travel)
        {
            Console.Clear();
            Console.Write("Введите количество денег потраченные в путешествии: ");
            double money;
            while (!double.TryParse(Console.ReadLine(), out money))
            {
                Console.Write("Попробуйте снова ввести количество денег: ");
            }
            travel.Money = money;
            Console.WriteLine("Для перехода в меню нажмите любую клавишу...");
            Console.ReadKey();
        }
        public void PrintStatistic()
        {
            Console.WriteLine(ToString());
        }

    }
}
