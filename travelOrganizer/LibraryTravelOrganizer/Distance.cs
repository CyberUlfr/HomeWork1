using System.Collections.Generic;
using System;
using System.Linq;

namespace travelOrganizer

{
    public class Distance
    {
        static public string[] MenuDistanceStrings =
        {
             "1 - Вывести список передвежений",
             "2 - Добавить передвежение",
             "3 - Вернуться назад",
        };
        static public void PrintMenuDistance()
        {
            Console.Clear();
            foreach (var menuDistanceString in MenuDistanceStrings)
            {
                Console.WriteLine(menuDistanceString);
            }
            Console.WriteLine("Нажмите цифру, соответствующую номеру меню.");
        }
        public double KMeters { get; set; }
        public string Name { get; set; }
        public Distance() { Name = "Без имени"; KMeters = 0; }
        public Distance(string name, double kmeters)
        {
            Name = name;
            KMeters = kmeters;
        }
        public override string ToString()
        {
            return string.Format($"{Name} прошел {KMeters} км.");
        }
        static public void PrintList(List<Distance> distances)
        {
            Console.Clear();
            if (distances.Count == 0)
            {
                Console.WriteLine("Список пуст.");
            }
            else
            {
                foreach (Distance elem in distances)
                {
                    Console.WriteLine( $" В этом отрезке пути: {elem.Name} прошел {elem.KMeters} км.");
                }
            }
            Console.WriteLine("Для перехода в меню нажмите любую клавишу...");
            Console.ReadKey();
        }
        static public void AddElem(List<Distance> distances)
        {
            Console.Clear();
            Console.Write("Введите название предвижения: ");
            string name = Console.ReadLine();
            while (name.Trim() == "")
            {
                Console.Write("Попробуйте снова ввести название: ");
                name = Console.ReadLine();
            }
            Console.Write("Введите растояние в километрах: ");
            int kmeters;
            while (!Int32.TryParse(Console.ReadLine(), out kmeters))
            {
                Console.Write("Попробуйте снова ввести растояние: ");
            }
            distances.Add(new Distance(name, kmeters));
            Console.WriteLine("Для перехода в меню нажмите любую клавишу...");
            Console.ReadKey();
        }
        static public void Sum(List<Distance> distances)
        {
            Console.Clear();
            if (distances.Count == 0)
            {
                Console.WriteLine("Список пуст.");
            }
            else
            {
                double sum = distances.Sum(elem => elem.KMeters);
                Console.WriteLine($"Сумма пути = {sum:N2} км.");
            }
            Console.WriteLine("Для перехода в меню нажмите любую клавишу...");
            Console.ReadKey();
        }
        public static void StartDistance(List<Distance> distances)
        {
            ConsoleKey key = ConsoleKey.Enter;
            do
            {
                PrintMenuDistance();
                key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.D1:
                        PrintList(distances);
                        break;
                    case ConsoleKey.D2:
                        AddElem(distances);
                        break;
                    default: continue;
                }
            } while (key != ConsoleKey.D3);
            Console.WriteLine("Удачи!");
        }
    }
}

