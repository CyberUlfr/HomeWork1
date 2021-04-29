using System;
using System.Collections.Generic;
using System.Linq;

namespace travelOrganizer
{
    static public class Menu
    {
        public static User ActiveUser { get; set; }
        public static List<Purchase> purchases { get; set; }
        static public Journey SelectedJourney { get; set; }
        static private string[] MainMenuStrings { get; set; } =
        {
             "1 - Покупки",
             "2 - Передвижения",
             "3 - Статистика",
             "4 - Выбрать путишествие",
             "5 - Вернуться в основное меню",
        };
        static void MenuPurchase1(User user)
        {
            ActiveUser = user;
            for (int i = 0; i < SelectedJourney.Purchases[ActiveUser].Count; i++)
            {
                Purchase purchase = SelectedJourney.Purchases[ActiveUser][i];
            }
        }
        static bool MenuInit(User user)
        {
            Console.Clear();
            ActiveUser = user;
            List<Journey> Journeys = Journey.Journeys.ToArray().Where(j => j.Users.Contains(ActiveUser)).ToList();
            for (int i = 0; i < Journeys.Count; i++)
            {
                Console.WriteLine("{0}:Название путешествия - {1}", i + 1, Journeys[i]);
            }
            do
            {
                if (Journeys.Count > 0)
                {
                    Console.Write("Введите номер путешествия: ");
                    var journeyNumber = Convert.ToInt32(Console.ReadLine());
                    if (journeyNumber > 0 && journeyNumber <= Journeys.Count)
                    {
                        SelectedJourney = Journeys[journeyNumber - 1];
                        return true;
                    }
                    Console.Clear();
                    Console.WriteLine("Номер путешествия введен неверно.");
                }
                else
                {
                    Console.WriteLine("Пользователь не участвует в путешествиях. Возврат в меню выбора пользователя");
                    Console.ReadKey();
                    return false;
                }
            } while (true);
        }
        static public void PrintMenu()
        {
            Console.Clear();
            foreach (var mainmenuString in MainMenuStrings)
            {
                Console.WriteLine(mainmenuString);
            }
            Console.WriteLine("Нажмите цифру, соответствующую номеру меню.");
        }
        static public void MenuRun(User user)
        {
            if (!MenuInit(user))
                return;
            ConsoleKey key = ConsoleKey.Enter;
            do
            {
                PrintMenu();
                key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.D1:
                        MenuPurchase1(ActiveUser);
                        break;
                    case ConsoleKey.D2:
                        MenuPurchase.Start(purchases);
                        break;
                    case ConsoleKey.D4:
                        MenuInit(ActiveUser);
                        break;    
                }
            } while (key != ConsoleKey.D5);
        }
    }
}
