using System;
using System.Collections.Generic;
using System.Linq;

namespace travelOrganizer
{
    class Program
    {
        static public string[] MenuStrings =
        {
             "1 - Вывод списка покупок в поездку",
             "2 - Добавить то что нужно купить",
             "3 - Удалить вещь из списка",
             "4 - Поиск вещей из списка",
             "6 - Выход",
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
        static public void PrintList(Dictionary<string, int> format)
        {
            Console.Clear();
            Console.WriteLine("1 - Вывести список");
            Console.WriteLine("2 - Сортировать по возрастанию");
            Console.WriteLine("3 - Сортировать по убыванию");
            Console.WriteLine("4 - Вернуться в меню");
            void list()
            {
                Console.Clear();
                if (format.Count == 0)
                {
                    Console.WriteLine("Список пуст.");
                }
                else
                {
                    foreach (KeyValuePair<string, int> elem in format)
                    {
                        Console.WriteLine("Название продукта = {0}, Его стоймость = {1} руб.", elem.Key, elem.Value);
                    }
                }
                Console.WriteLine("Для перехода в меню нажмите любую клавишу...");
                Console.ReadKey();
            }
            void ListSortedIncrease()
            {
                Console.Clear();
                if (format.Count == 0)
                {
                    Console.WriteLine("Список пуст.");
                }
                else
                {
                    IEnumerable<KeyValuePair<string, int>> sortedPrice = format.OrderBy(elem => elem.Value);
                    foreach (KeyValuePair<string, int> elem in sortedPrice)
                    {
                        Console.WriteLine("Название продукта = {0}, Его стоймость = {1} руб.", elem.Key, elem.Value);
                    }
                }
                Console.WriteLine("Для перехода в меню нажмите любую клавишу...");
                Console.ReadKey();
            }
            void ListSortedDescending()
            {
                Console.Clear();
                if (format.Count == 0)
                {
                    Console.WriteLine("Список пуст.");
                }
                else
                {
                    IEnumerable<KeyValuePair<string, int>> sortedPrice = format.OrderByDescending(elem => elem.Value);
                    foreach (KeyValuePair<string, int> elem in sortedPrice)
                    {
                        Console.WriteLine("Название продукта = {0}, Его стоймость = {1} руб.", elem.Key, elem.Value);
                    }
                }
                Console.WriteLine("Для перехода в меню нажмите любую клавишу...");
                Console.ReadKey();
            }
            ConsoleKey key = ConsoleKey.Enter;
            key = Console.ReadKey().Key;
            switch (key)
            {
                case ConsoleKey.D1:
                    list();
                    break;
                case ConsoleKey.D2:
                    ListSortedIncrease();
                    break;
                case ConsoleKey.D3:
                    ListSortedDescending();
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("Удачи!");
                    break;
                default: break;
            }       
        } 
        static public void AddElem(Dictionary<string, int> format)
        {
            Console.Clear();
            Console.Write("Введите название продукта: ");
            string shortDescription = Console.ReadLine();
            while (shortDescription.Trim() == "")
            {
                Console.Write("Попробуйте снова ввести название: ");
                shortDescription = Console.ReadLine();
            }
            Console.Write("Введите стоимость продукта в рублях: ");
            int fullDescription;
            while (!Int32.TryParse(Console.ReadLine(), out fullDescription))
            {
                Console.Write("Попробуйте снова ввести стоимость: ");
            }
            format.Add(shortDescription, fullDescription);
            Console.WriteLine("Для перехода в меню нажмите любую клавишу...");
            Console.ReadKey();
        }
        static public void RemoveElem(Dictionary<string, int> format)
        {
            Console.Clear();
            Console.Write("Введите название продукта который хотите удалить из списка: ");
            string shortDescription = Console.ReadLine();
            while (shortDescription.Trim() == "")
            {
                Console.Write("Попробуйте снова ввести название: ");
                shortDescription = Console.ReadLine();
            }
            if (format.Remove(shortDescription))
            {
                Console.Write("Продукт удалён");
            }
            else
            {
                Console.Write("Название продукта введено неверно");
            }
            Console.WriteLine();
            Console.WriteLine("Для перехода в меню нажмите любую клавишу...");
            Console.ReadKey();
        }
        static public void SearchElem(Dictionary<string, int> format)
        {
            Console.Clear();
            Console.Write("Введите название продукта который хотите хотите найти: ");
            string shortDescription = Console.ReadLine();
            while (shortDescription.Trim() == "")
            {
                Console.Write("Попробуйте снова ввести название: ");
                shortDescription = Console.ReadLine();
            }
            if (format.ContainsKey(shortDescription))
            {
                Console.Write($"Стоимость продукта = {format[shortDescription]} руб.");
            }
            else
            {
                Console.Write("Название продукта введено неверно");
            }
            Console.WriteLine();
            Console.WriteLine("Для перехода в меню нажмите любую клавишу...");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Dictionary<string, int> Format = new Dictionary<string, int>();
            ConsoleKey key = ConsoleKey.Enter;
            do
            {
                PrintMenu();
                key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.D1:
                        PrintList(Format);
                        break;
                    case ConsoleKey.D2:
                        AddElem(Format);
                        break;
                    case ConsoleKey.D3:
                        RemoveElem(Format);
                        break;
                    case ConsoleKey.D4:
                        SearchElem(Format);
                        break;
                    default: continue;
                }
            } while (key != ConsoleKey.D6);
            Console.WriteLine("Удачи!");
        }
    }
}
