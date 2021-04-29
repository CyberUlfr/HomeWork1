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
             "3 - Управление пользователями",
             "4 - Список путешествий",
             "5 - Меню пользователя",
             "6 - Вернуться назад",
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
        public static void MenuAdmin(User user)
        {
            ConsoleKey key = ConsoleKey.Enter;
            ActiveUser = user;
            do
            {
                PrintMenuAdmin();
                key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.D1:
                        AddJourney();
                        break;
                    case ConsoleKey.D2:
                        RemoveJourney();
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
            } while (key != ConsoleKey.D6);
            Console.WriteLine("Удачи!");
        }
        public static void AddUsers()
        {
            string userName;
            do
            {
                Console.Clear();
                Console.Write("Введите имя пользователя или введите пустое поле чтобы завершить ввод пользователя : ");
                userName = Console.ReadLine();
                if (userName.Trim() != "")
                {
                    if (!User.Users.Any(elem => elem.Name == userName))
                    {
                        User.Users.Add(new User(userName));
                        Console.Write("Пользователь добавлен. Для продолжения нажмите на любую клавишу!");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.Write($"Данный пользователь {userName} уже добавлен!");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.Write("Введено пустое поле, возврат в меню.");
                    Console.ReadKey();
                    return;
                }
            } while (!string.IsNullOrWhiteSpace(userName));
        }
        public static void RemoveUsers()
        {
            string userName;
            do
            {
                Console.Clear();
                Console.Write("Введите имя пользователя или введите пустое поле чтобы завершить ввод пользователя : ");
                userName = Console.ReadLine();
                if (userName.Trim() != "")
                {
                    if (!User.Users.Find(elem => elem.Name == userName).IsAdmin)
                    {
                        if (User.Users.Any(elem => elem.Name == userName))
                        {
                            User.Users.Remove(User.Users.Find(elem => elem.Name == userName));
                            Console.Write("Пользователь удалён! Для продолжения нажмите на любую клавишу.");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.Write($"Данный пользователь {userName} не добавлен!");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.Write("Нельзя удалять админа!!");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.Write("Введено пустое поле, возврат в меню.");
                    Console.ReadKey();
                }
            } while (!string.IsNullOrWhiteSpace(userName));
        }
        public static void AddJourney()
        {
            Console.Clear();
            string journeyName;
            do
            {
                Console.Write("Введите название путишествия: ");
                journeyName = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(journeyName));
            List<User> users = new List<User>();
            string userName;
            do
            {
                Console.Clear();
                Console.Write("Введите имя пользователя или нажмите Enter чтобы завершить ввод пользователя : ");
                userName = Console.ReadLine();
                User user = User.Users.Where(u => u.Name == userName).ToList().FirstOrDefault();
                if(userName.Trim() != "")
                {
                    if (User.Users.Any(elem => elem.Name == userName))
                    {
                        if (!users.Contains(user) && user != null)
                        {
                            users.Add(user);
                        }
                        else
                        {
                            Console.Write($"Данный пользователь {userName} уже добавлен!");
                        }
                    }
                    else
                    {
                        Console.Write($"Такого пользователя не существует!");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.Write("Введено пустое поле, возврат в меню.");
                    Console.ReadKey();
                }
            } while (!string.IsNullOrWhiteSpace(userName));
            new Journey(journeyName, users);
            Journey.Journeys.Last().Start();
        }
        public static void RemoveJourney()
        {
            Console.Clear();
            string journeyName;
            do
            {
                Console.Clear();
                for (int i = 0; i < Journey.Journeys.Count; i++)
                {
                    Console.WriteLine("{0}:Название путешествия - {1}", i + 1, Journey.Journeys[i]);
                }
                Console.Write("Введите названия путешествия или введите пустое поле чтобы завершить ввод путешествия : ");
                journeyName = Console.ReadLine();
                if (journeyName.Trim() != "")
                {
                    if (Journey.Journeys.Any(elem => elem.Name == journeyName))
                    {
                        Journey.Journeys.Remove(Journey.Journeys.Find(elem => elem.Name == journeyName));
                        Console.Write("Путишествие удалено! Для продолжения нажмите на любую клавишу.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.Write("Путишествие не добавлено!");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.Write("Введено пустое поле, возврат в меню.");
                    Console.ReadKey();
                    return;
                }
            } while (!string.IsNullOrWhiteSpace(journeyName)) ;
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
             "4 - Вернуться назад",
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
                    case ConsoleKey.D2:
                        RemoveUsers();
                        break;
                    case ConsoleKey.D3:
                        ListUser();
                        break;
                    default: continue;
                }
            } while (key != ConsoleKey.D4);
            Console.WriteLine("Удачи!");
        }
    }
}
