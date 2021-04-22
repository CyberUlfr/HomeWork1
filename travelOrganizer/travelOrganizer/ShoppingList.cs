using System;
using System.Collections.Generic;
using System.Linq;

namespace travelOrganizer
{
    class ShoppingList
    {
        static public string[] MenuStrings =
        {
             "1 - Меню работы со списком покупок",
             "2 - Добавить то что нужно купить",
             "3 - Удалить вещь из списка",
             "4 - Поиск вещей из списка",
             "5 - Вернуться назад",
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
            Console.WriteLine("1 - Вывести список");
            Console.WriteLine("2 - Сортировать по возрастанию");
            Console.WriteLine("3 - Сортировать по убыванию");
            Console.WriteLine("4 - Фильтр цен до 100 руб");
            Console.WriteLine("5 - Первести цену из руб. в доллары");
            Console.WriteLine("6 - Посчитать общую стоймость");
            Console.WriteLine("7 - Самый дешевый и дорогой продукт");
            Console.WriteLine("8 - Вернуться в меню покупок");
            void list()
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
            void ListSortedIncrease()
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
            void ListSortedDescending()
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
            void ListPriceBelow100()
            {
                Console.Clear();
                if (format.Count == 0)
                {
                    Console.WriteLine("Список пуст.");
                }
                else
                {
                    var Below100 = format.Where(elem => elem.Value <= 100);
                    foreach (KeyValuePair<string, double> elem in Below100)
                    {
                        Console.WriteLine("Название продукта = {0}, Его стоймость = {1:N2} руб.", elem.Key, elem.Value);
                    }
                }
                Console.WriteLine("Для перехода в меню нажмите любую клавишу...");
                Console.ReadKey();
            }
            void ListTransferToDollars()
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
            void Sum()
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
            void MinMax()
            {
                Console.Clear();
                if (format.Count == 0)
                {
                    Console.WriteLine("Список пуст.");
                }
                else
                {
                    var Min = format.Min(elem => (elem.Value, elem.Key));
                    var Max = format.Max(elem => (elem.Value, elem.Key));
                    Console.WriteLine($"Самый дешевый продукт = {Min.Key} : {Min.Value:N2} руб. Самый дорогой продукт = {Max.Key} : {Max.Value:N2} руб.");
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
                    ListPriceBelow100();
                    break;
                case ConsoleKey.D5:
                    ListTransferToDollars();
                    break;
                case ConsoleKey.D6:
                    Sum();
                    break;
                case ConsoleKey.D7:
                    MinMax();
                    break;
                case ConsoleKey.D8:
                    Console.WriteLine("Удачи!");
                    break;
                default: break;
            }
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
                    default: continue;
                }
            } while (key != ConsoleKey.D5);

            Console.WriteLine("Удачи!");
        }
    }
}
