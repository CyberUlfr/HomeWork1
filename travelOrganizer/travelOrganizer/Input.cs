using System;

namespace travelOrganizer
{
    public class Input
    {
        static private string[] MainMenuStrings { get; set; } =
        {
             "1 - Список пользователей",
             "2 - Выход",
        };
        static public void PrintMainMenu()
        {
            Console.Clear();
            foreach (var mainmenuString in MainMenuStrings)
            {
                Console.WriteLine(mainmenuString);
            }
            Console.WriteLine("Нажмите цифру, соответствующую номеру меню.");
        }
        public static void Main()
        {
            ConsoleKey key = ConsoleKey.Enter;
            do
            {
                PrintMainMenu();
                key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.D1:
                        User.StartUser();
                        break;
                    default: continue;
                }
            } while (key != ConsoleKey.D2);
            Environment.Exit(0);
            Console.WriteLine("Удачи!");
        }
    }
}

