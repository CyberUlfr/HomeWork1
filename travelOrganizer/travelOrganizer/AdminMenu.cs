using System;
using System.Collections.Generic;

namespace travelOrganizer
{
    public class AdminMenu
    {
        public static Dictionary<int, Journey> Journeys { get; set; } = new Dictionary<int, Journey>();
        static public string[] MenuAdminStrings { get; set; } =
        {
             "Раздел админа:",
             "1 - Добавить путешествие",
             "2 - Удалить путешествие",
             "3 - Меню управления путешествием",
             "4 - Список путешествий",
             "Раздел пользователя:",
             "5 - Покупки",
             "6 - Передвижения",
             "7 - Статистика",
             "8 - Выход",
        };
        static public void PrintMenuAdmin()
        {
            Console.Clear();
            foreach (var adminString in MenuAdminStrings)
            {
                Console.WriteLine(adminString);
            }
            Console.WriteLine("Нажмите цифру, соответствующую номеру меню.");
        }
        public static void MenuAdmin()
        {
            ConsoleKey key = ConsoleKey.Enter;
            do
            {
                PrintMenuAdmin();
                key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.D1:
                        AddJourney();
                        break;
                    case ConsoleKey.D3:
                        TravelManagement();
                        break;
                    case ConsoleKey.D4:
                        Journey.ListJourney();
                        break;
                    case ConsoleKey.D5:
                        MenuPurchase.Start();
                        break;
                    default: continue;
                }
            } while (key != ConsoleKey.D8);
            Input.Main();
            Console.WriteLine("Удачи!");
        }
        public static void AddUsers()
        {
            Console.Clear();
            Console.Write("Введите имя пользователя: ");
            var userName = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(userName))
            {
                new User(userName);
            }
        }
        public static void RemoveUsers()
        {
            Console.Clear();
            Console.Write("Введите имя пользователя: ");
            var userName = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(userName)) ;
        }
        public static void AddJourney()
        {
            Console.Clear();
            Console.Write("Введите название путишествия: ");
            var journeyName = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(journeyName))
            {
                new Journey(journeyName);
            }
        }
        static public void ListUser()
        {
            Console.Clear();
            foreach (var user in User.Users)
            {
                Console.WriteLine("Список пользователей = {0}", user.Name);
            }
            Console.WriteLine("Для перехода в меню нажмите любую клавишу...");
            Console.ReadKey();
        }
        static public string[] MenuTravelManagement { get; set; } =
        {
             "1 - Добавить пользователя",
             "2 - Удалить пользователя",
             "3 - Показать список пользователей",
             "4 - Выход",
        };
        static public void PrintMenuTravelManagement()
        {
            Console.Clear();
            foreach (var managementString in MenuTravelManagement)
            {
                Console.WriteLine(managementString);
            }
            Console.WriteLine("Нажмите цифру, соответствующую номеру меню.");
        }
        public static void TravelManagement()
        {
            ConsoleKey key = ConsoleKey.Enter;
            do
            {
                PrintMenuTravelManagement();
                key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.D1:
                        AddUsers();
                        break;
                    case ConsoleKey.D3:
                        ListUser();
                        break;
                    default: continue;
                }
            } while (key != ConsoleKey.D4);
            Input.Main();
            Console.WriteLine("Удачи!");
        }
    }
}
