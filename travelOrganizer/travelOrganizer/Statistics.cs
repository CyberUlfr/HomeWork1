using System;
using System.Collections.Generic;
using System.Linq;

namespace travelOrganizer
{
    class Statistics
    {
        static public string[] MenuStatistics =
        {
             "1 - Статистика по путешествиям",
             "2 - Записать сколько км. проехал в путешествии",
             "3 - Записать сколько часов провел в путешествии",
             "4 - Записать сколько потратил денег в путешествии",
             "6 - Вернуться в основное меню",
        };
        static public void PrintMenuStatistics()
        {
            Console.Clear();
            foreach (var menuStatistics in MenuStatistics)
            {
                Console.WriteLine(menuStatistics);
            }
            Console.WriteLine("Нажмите цифру, соотсвтующию номеру меню.");
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
            Console.WriteLine("Нажмите цифру, соотсвтующию номеру меню.");
        }
        
    }
    class travel
    {
        public double Distance { get; set; }
        public double Time { get; set; }
        public double Money { get; set; }
        public travel(double distance, double time, double money)
        {
            Distance = distance;
            Time = time;
            Money = money;
        }

        public override string ToString()
        {
            return string.Format("{0};{1};{2}", Distance, Time, Money);
        }
        static public void AddDistance(List<double> travel)
        {
            Console.Clear();
            Console.Write("Введите растояние пройденное в путешествии: ");
            double distance;
            while (!double.TryParse(Console.ReadLine(), out distance))
            {
                Console.Write("Попробуйте снова ввести растояние: ");
            }
            Console.WriteLine("Для перехода в меню нажмите любую клавишу...");
            Console.ReadKey();
        }
        static public void AddTime(List<double> travel)
        {
            Console.Clear();
            Console.Write("Введите время проведенное в путешествии: ");
            double time;
            while (!double.TryParse(Console.ReadLine(), out time))
            {
                Console.Write("Попробуйте снова ввести время: ");
            }
            travel.Add(time);
            Console.WriteLine("Для перехода в меню нажмите любую клавишу...");
            Console.ReadKey();
        }
        static public void AddMoney(List<double> travel)
        {
            Console.Clear();
            Console.Write("Введите количество денег потраченные в путешествии: ");
            double money;
            while (!double.TryParse(Console.ReadLine(), out money))
            {
                Console.Write("Попробуйте снова ввести количество денег: ");
            }
            travel.Add(money);
            Console.WriteLine("Для перехода в меню нажмите любую клавишу...");
            Console.ReadKey();
        }

    }
}
