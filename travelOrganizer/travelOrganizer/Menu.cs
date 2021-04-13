using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace travelOrganizer
{
    class Menu
    {
        static private string[] MainMenuStrings { get; set; } =
        {
             "1 - Меню покупок",
             "2 - Меню статистики",
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
        public static void Main (string[] args)
        {
            ConsoleKey key = ConsoleKey.Enter;
            do
            {
                PrintMainMenu();
                key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.D1:
                        ShoppingListMenu();
                        break;
                    default: continue;
                }
            } while (key != ConsoleKey.D3);
            Console.WriteLine("Удачи!");
        }
        public static void ShoppingListMenu()
        {
            ShoppingList.Start();
        }
    }
}
