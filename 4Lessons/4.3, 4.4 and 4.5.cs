using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._3_and_4._4
{
    class Program
    {
        static public string[] MenuStrings =
        {
             "1 - Найти минимальный и максимальный элемент",
             "2 - Посчитать кол-во разных чисел",
             "3 - Найти элементы из рандомных чисел",
             "4 - Выйти",
        };
        static public void PrintMenu()
        {
            Console.Clear();
            foreach (var menuString in MenuStrings)
            {
                Console.WriteLine(menuString);
            }
            Console.WriteLine("Нажмите цифру, соотсвтующию номеру меню.");
        }
        static void MinMax(List<int> func)
        {
            Console.Clear();
            Console.Write("Введите сколько чисел хотите написать:");
            int collectionSize = int.Parse(Console.ReadLine());
            List<int> collection = new List<int>();
            Console.WriteLine("Введите числа по очереди:");
            for (int i = 0; i < collectionSize; ++i)
            {
                collection.Add(int.Parse(Console.ReadLine()));
            }
            int min = collection.OrderBy(x => x).First();
            int max = collection.OrderBy(x => x).Last();
            Console.WriteLine($"Минимальный элемент: {min}");
            Console.WriteLine($"Максимальный элемент: {max}");
            Console.WriteLine("Нажмите Enter чтобы вернуться в меню.");
            Console.ReadLine();
        }
        static void DifferentNumbers(List<int> func)
        {
            Console.Clear();
            Console.Write("Введите сколько чисел хотите написать:");
            int collectionSize = int.Parse(Console.ReadLine());
            List<int> collection = new List<int>();
            Console.WriteLine("Введите числа по очереди:");
            for (int i = 0; i < collectionSize; ++i)
            {
                collection.Add(int.Parse(Console.ReadLine()));
            }
            int differentNums = collection.Distinct().Count();
            Console.WriteLine($"Количество разных чисел: {differentNums}");
            Console.WriteLine("Нажмите Enter чтобы вернуться в меню.");
            Console.ReadLine();
        }
        static void RandomNumbers(List<int> func)
        {
            Console.Clear();
            Random rand = new Random();
            List<int> collection = new List<int>(50);
            for (int i = 0; i < 50; i++)
            {
                collection.Add(rand.Next(0, 25));
            }
            foreach (int elem in collection.Where(x => x >= 10 & x <= 20).Distinct().OrderByDescending(x => x))
            {
                Console.Write(elem + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Нажмите Enter чтобы вернуться в меню.");
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            List<int> collection = new List<int>();
            ConsoleKey key = ConsoleKey.Enter;
            do
            {
                PrintMenu();
                key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.D1:
                        MinMax(collection);
                        break;
                    case ConsoleKey.D2:
                        DifferentNumbers(collection);
                        break;
                    case ConsoleKey.D3:
                        RandomNumbers(collection);
                        break;
                    default: continue;
                }
            } while (key != ConsoleKey.D4);
            Console.WriteLine("Удачи!");
        }

    }
}
