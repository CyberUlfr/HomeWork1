using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace travelOrganizer
{
    class AdminMenu
    {
        static public string[] MenuAdminStrings { get; set; } =
        {
             "1 - Добавить пользователя",
             "2 - Удалить пользователя",
             "3 - Добавить путешествие",
             "4 - Удалить путешествие",
             "3 - Выход",
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
                        AddUsers();
                        break;
                    case ConsoleKey.D3:
                        AddJourney();
                        break;
                    default: continue;
                }
            } while (key != ConsoleKey.D5);
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
    }
}
