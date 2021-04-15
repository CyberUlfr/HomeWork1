using System;

namespace travelOrganizer
{
    class Input
    {
        static private string[] MainMenuStrings { get; set; } =
        {
             "1 - Список пользователей",
             "2 - Меню админа",
             "3 - Выход",
        };
        static public void PrintMainMenu()
        {
            Console.Clear();
            foreach (var mainmenuString in MainMenuStrings)
            {
                Console.WriteLine(mainmenuString);
            }
            Console.WriteLine("Нажмите цифру, соотсвтующию номеру меню.");
        }
        public static void Main(string[] args)
        {
            ConsoleKey key = ConsoleKey.Enter;
            do
            {
                PrintMainMenu();
                key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.D1:
                        Users1();
                        break;
                    default: continue;
                    case ConsoleKey.D2:
                        Admin();
                        break;
                }
            } while (key != ConsoleKey.D3);
            Console.WriteLine("Удачи!");
        }
        public static void Users1()
        {
            Users.StartUser();
        }
        private static void Admin()
        {
            Console.Write("Введите имя пользователя: ");
        }
    }
}

