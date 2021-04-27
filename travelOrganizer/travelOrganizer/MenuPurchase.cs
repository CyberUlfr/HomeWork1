using System;
using System.Collections.Generic;
using System.Linq;

namespace travelOrganizer
{
    public class MenuPurchase
    {
        static public string[] MenuStrings =
        {
             "1 - Вывести список",
             "2 - Добавить то, что нужно купить",
             "3 - Удалить вещь из списка",
             "4 - Поиск вещей из списка",
             "5 - Посчитать общую стоймость",
             "6 - Перевести цену из руб. в доллары",
             "7 - Сортировать по возрастанию",
             "8 - Сортировать по убыванию",
             "9 - Вернуться назад",
        };
        static public void PrintMenu()
        {
            Console.Clear();
            foreach (var menuString in MenuStrings)
            {
                Console.WriteLine(menuString);
            }
            Console.WriteLine("Нажмите цифру, соответствующую номеру меню.");
        }
        static public void PrintList(Dictionary<string, double> format)
        {
            Console.Clear();
            if (format.Count == 0)
            {
                Console.WriteLine("Список пуст.");
            }
            else
            {
                foreach (KeyValuePair<string, double> elem in format)
                {
                    Console.WriteLine("Название продукта = {0}, Его стоймость = {1:N2} руб.", elem.Key, elem.Value);
                }
            }
            Console.WriteLine("Для перехода в меню нажмите любую клавишу...");
            Console.ReadKey();
        }
        static public void AddElem(Dictionary<string, double> format)
        {
            Console.Clear();
            Console.Write("Введите название продукта: ");
            string productName = Console.ReadLine();
            while (productName.Trim() == "")
            {
                Console.Write("Попробуйте снова ввести название: ");
                productName = Console.ReadLine();
            }
            Console.Write("Введите стоимость продукта в рублях: ");
            int price;
            while (!Int32.TryParse(Console.ReadLine(), out price))
            {
                Console.Write("Попробуйте снова ввести стоимость: ");
            }
            format.Add(productName, price);
            Console.WriteLine("Для перехода в меню нажмите любую клавишу...");
            Console.ReadKey();
        }
        static public void RemoveElem(Dictionary<string, double> format)
        {
            Console.Clear();
            Console.Write("Введите название продукта который хотите удалить из списка: ");
            string productName = Console.ReadLine();
            while (productName.Trim() == "")
            {
                Console.Write("Попробуйте снова ввести название: ");
                productName = Console.ReadLine();
            }
            if (format.Remove(productName))
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
        static public void SearchElem(Dictionary<string, double> format)
        {
            Console.Clear();
            Console.Write("Введите название продукта который хотите хотите найти: ");
            string productName = Console.ReadLine();
            while (productName.Trim() == "")
            {
                Console.Write("Попробуйте снова ввести название: ");
                productName = Console.ReadLine();
            }
            if (format.ContainsKey(productName))
            {
                Console.Write($"Стоимость продукта = {format[productName]} руб.");
            }
            else
            {
                Console.Write("Название продукта введено неверно");
            }
            Console.WriteLine();
            Console.WriteLine("Для перехода в меню нажмите любую клавишу...");
            Console.ReadKey();
        }
        static public void Sum(Dictionary<string, double> format)
        {
            Console.Clear();
            if (format.Count == 0)
            {
                Console.WriteLine("Список пуст.");
            }
            else
            {
                var sum = format.Aggregate((elem1, elem2) => new KeyValuePair<string, double>(elem1.Key, elem1.Value + elem2.Value));
                Console.WriteLine($"Сумма всех продуктов = {sum.Value:N2} руб.");
            }
            Console.WriteLine("Для перехода в меню нажмите любую клавишу...");
            Console.ReadKey();
        }
        static public void ListTransferToDollars(Dictionary<string, double> format)
        {
            Console.Clear();
            if (format.Count == 0)
            {
                Console.WriteLine("Список пуст.");
            }
            else
            {
                foreach (KeyValuePair<string, double> elem in format.Select(elem => new KeyValuePair<string, double>(elem.Key, elem.Value / 77)))
                {
                    Console.WriteLine("Название продукта = {0}, Его стоймость в долларах = {1:N2} usd.", elem.Key, elem.Value);
                }
            }
            Console.WriteLine("Для перехода в меню нажмите любую клавишу...");
            Console.ReadKey();
        }
        static public void ListSortedIncrease(Dictionary<string, double> format)
        {
            Console.Clear();
            if (format.Count == 0)
            {
                Console.WriteLine("Список пуст.");
            }
            else
            {
                var sortedPrice = format.OrderBy(elem => elem.Value);
                foreach (KeyValuePair<string, double> elem in sortedPrice)
                {
                    Console.WriteLine("Название продукта = {0}, Его стоймость = {1:N2} руб.", elem.Key, elem.Value);
                }
            }
            Console.WriteLine("Для перехода в меню нажмите любую клавишу...");
            Console.ReadKey();
        }
        static public void ListSortedDescending(Dictionary<string, double> format)
        {
            Console.Clear();
            if (format.Count == 0)
            {
                Console.WriteLine("Список пуст.");
            }
            else
            {
                var sortedPrice = format.OrderByDescending(elem => elem.Value);
                foreach (KeyValuePair<string, double> elem in sortedPrice)
                {
                    Console.WriteLine("Название продукта = {0}, Его стоймость = {1:N2} руб.", elem.Key, elem.Value);
                }
            }
            Console.WriteLine("Для перехода в меню нажмите любую клавишу...");
            Console.ReadKey();
        }
        public static void Start()
        {
            Dictionary<string, double> Format = new Dictionary<string, double>();
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
                    case ConsoleKey.D5:
                        Sum(Format);
                        break;
                    case ConsoleKey.D6:
                        ListTransferToDollars(Format);
                        break;
                    case ConsoleKey.D7:
                        ListSortedIncrease(Format);
                        break;
                    case ConsoleKey.D8:
                        ListSortedDescending(Format);
                        break;
                    default: continue;
                }
            } while (key != ConsoleKey.D9);
            Console.WriteLine("Удачи!");
        }
    }

}
