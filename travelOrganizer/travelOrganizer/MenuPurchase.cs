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
        static public void PrintList(List<Purchase> purchases)
        {
            Console.Clear();
            if (Purchase.Purchases.Count == 0)
            {
                Console.WriteLine("Список пуст.");
            }
            else
            {
                foreach (Purchase elem in Purchase.Purchases)
                {
                    Console.WriteLine("Название продукта = {0}, Его стоймость = {1:N2} руб.", elem.Name, elem.Price);
                }
            }
            Console.WriteLine("Для перехода в меню нажмите любую клавишу...");
            Console.ReadKey();
        }
        static public void AddElem(List<Purchase> purchases)
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
            new Purchase(productName, price);
            Console.WriteLine("Для перехода в меню нажмите любую клавишу...");
            Console.ReadKey();
        }
        static public void RemoveElem(List<Purchase> purchases)
        {
            Console.Clear();
            Console.Write("Введите название продукта который хотите удалить из списка: ");
            string productName = Console.ReadLine();
            while (productName.Trim() == "")
            {
                Console.Write("Попробуйте снова ввести название: ");
                productName = Console.ReadLine();
            }
            Purchase purchase = Purchase.Purchases.Where(u => u.Name == productName).ToList().FirstOrDefault();
            if (Purchase.Purchases.Remove(purchase))
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
        static public void SearchElem(List<Purchase> purchases)
        {
            Console.Clear();
            Console.Write("Введите название продукта который хотите хотите найти: ");
            var productName = Console.ReadLine();
            while (productName.Trim() == "")
            {
                Console.Write("Попробуйте снова ввести название: ");
                productName = Console.ReadLine();
            }
            Purchase purchase = Purchase.Purchases.Where(u => u.Name == productName).ToList().First();
            if (Purchase.Purchases.Contains(purchase))
            {
                Console.Write($"{purchase}");
            }
            else
            {
                Console.Write("Название продукта введено неверно");
            }
            Console.WriteLine();
            Console.WriteLine("Для перехода в меню нажмите любую клавишу...");
            Console.ReadKey();
        }
        static public void Sum(List<Purchase> purchases)
        {
            Console.Clear();
            if (Purchase.Purchases.Count == 0)
            {
                Console.WriteLine("Список пуст.");
            }
            else
            {
                var sum = Purchase.Purchases.Aggregate((elem1, elem2) => new Purchase(elem1.Name, elem1.Price + elem2.Price));
                Console.WriteLine($"Сумма всех продуктов = {sum.Price:N2} руб.");
            }
            Console.WriteLine("Для перехода в меню нажмите любую клавишу...");
            Console.ReadKey();
        }
        static public void ListTransferToDollars(List<Purchase> purchases)
        {
            Console.Clear();
            if (Purchase.Purchases.Count == 0)
            {
                Console.WriteLine("Список пуст.");
            }
            else
            {
                foreach (Purchase elem in Purchase.Purchases.Select(elem => new Purchase(elem.Name, elem.Price / 77)))
                {
                    Console.WriteLine("Название продукта = {0}, Его стоймость в долларах = {1:N2} usd.", elem.Name, elem.Price);
                }
            }
            Console.WriteLine("Для перехода в меню нажмите любую клавишу...");
            Console.ReadKey();
        }
        static public void ListSortedIncrease(List<Purchase> purchases)
        {
            Console.Clear();
            if (Purchase.Purchases.Count == 0)
            {
                Console.WriteLine("Список пуст.");
            }
            else
            {
                var sortedPrice = Purchase.Purchases.OrderBy(elem => elem.Name);
                foreach (Purchase elem in sortedPrice)
                {
                    Console.WriteLine("Название продукта = {0}, Его стоймость = {1:N2} руб.", elem.Name, elem.Price);
                }
            }
            Console.WriteLine("Для перехода в меню нажмите любую клавишу...");
            Console.ReadKey();
        }
        static public void ListSortedDescending(List<Purchase> purchases)
        {
            Console.Clear();
            if (Purchase.Purchases.Count == 0)
            {
                Console.WriteLine("Список пуст.");
            }
            else
            {
                var sortedPrice = Purchase.Purchases.OrderByDescending(elem => elem.Name);
                foreach (Purchase elem in sortedPrice)
                {
                    Console.WriteLine("Название продукта = {0}, Его стоймость = {1:N2} руб.", elem.Name, elem.Price);
                }
            }
            Console.WriteLine("Для перехода в меню нажмите любую клавишу...");
            Console.ReadKey();
        }
        public static void Start(List<Purchase> purchases)
        {
            ConsoleKey key = ConsoleKey.Enter;
            do
            {
                PrintMenu();
                key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.D1:
                        PrintList(purchases);
                        break;
                    case ConsoleKey.D2:
                        AddElem(purchases);
                        break;
                    case ConsoleKey.D3:
                        RemoveElem(purchases);
                        break;
                    case ConsoleKey.D4:
                        SearchElem(purchases);
                        break;
                    case ConsoleKey.D5:
                        Sum(purchases);
                        break;
                    case ConsoleKey.D6:
                        ListTransferToDollars(purchases);
                        break;
                    case ConsoleKey.D7:
                        ListSortedIncrease(purchases);
                        break;
                    case ConsoleKey.D8:
                        ListSortedDescending(purchases);
                        break;
                    default: continue;
                }
            } while (key != ConsoleKey.D9);
            Console.WriteLine("Удачи!");
        }
    }

}
