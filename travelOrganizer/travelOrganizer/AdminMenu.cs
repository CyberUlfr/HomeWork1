using System;
using System.Collections.Generic;
using System.Linq;

namespace travelOrganizer
{
    static public class AdminMenu
    {
        public static User ActiveUser { get; set; }
        public static List<Journey> Journeys { get; set; } = new List<Journey>();
        static public string[] MenuAdminStrings { get; set; } =
        {
             "Раздел админа:",
             "1 - Добавить путешествие",
             "2 - Удалить путешествие",
             "3 - Меню управления путешествием",
             "4 - Список путешествий",
             "5 - Меню пользователя",
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
                        Menu.MenuRun(ActiveUser);
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
            string journeyName;
            do
            {
                Console.Write("Введите название путишествия: ");
                journeyName = Console.ReadLine();
            } while (!string.IsNullOrWhiteSpace(journeyName));
            List<User> users = new List<User>();
            string userName;
            do
            {
                Console.Write("Введите имя пользователя или нажмите Enter чтобы завершить ввод пользователя : ");
                userName = Console.ReadLine();
                User user = User.Users.Where(u => u.Name == userName).ToList().First();
                if (!users.Contains(user))
                {
                    users.Add(user);
                }
                else
                {
                    Console.Write($"Данный пользователь{userName} уже добавлен!");
                }
            } while (!string.IsNullOrWhiteSpace(userName));
            new Journey(journeyName,users);
            Journey.Journeys.Last().Start();
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
             "3 - Добавить пользователя в путишествие",
             "4 - Показать список пользователей",
             "5 - Запустить путишествие",
             "6 - Выход",
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
            } while (key != ConsoleKey.D5);
            Input.Main();
            Console.WriteLine("Удачи!");
        }
    }
}
