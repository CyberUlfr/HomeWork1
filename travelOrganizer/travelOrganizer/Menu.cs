using System;

namespace travelOrganizer
{
    class Menu
    {
        static private string[] MainMenuStrings { get; set; } =
        {
             "1 - Меню покупок",
             "2 - Меню статистики",
             "3 - Вернуться в основное меню",
        };
        static public void PrintMenu()
        {
            Console.Clear();
            foreach (var mainmenuString in MainMenuStrings)
            {
                Console.WriteLine(mainmenuString);
            }
            Console.WriteLine("Нажмите цифру, соответствующую номеру меню.");
        }
        public static void MenuRun()
        {
            ConsoleKey key = ConsoleKey.Enter;
            do
            {
                PrintMenu();
                key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.D1:
                        ShoppingListMenu();
                        break;

                }
            } while (key != ConsoleKey.D3);
            Input.Main();
        }
        public static void ShoppingListMenu()
        {
            ShoppingList.Start();
        }
    }
}
