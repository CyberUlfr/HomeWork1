using System;
using System.Collections.Generic;
using System.Linq;

namespace travelOrganizer
{
    static public class Menu
    {
        public static User ActiveUser { get; set; }
        static public Journey SelectedJourney { get; set; }
        static private string[] MainMenuStrings { get; set; } =
        {
             "1 - Покупки",
             "2 - Передвижения",
             "3 - Статистика",
             "4 - Выбрать путишествие",
             "5 - Вернуться в основное меню",
        };
        static void MenuPurchase(User user)
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
            List<Journey> journeys = (List<Journey>)Journey.Journeys.Where(j => j.Users.Contains(ActiveUser));
            for (int i = 0; i < journeys.Count; i++)
            {
                Console.WriteLine("{0}:Название путешествия - {1}", i + 1, journeys[i]);
            }
            do
            {
                if (journeys.Count > 0)
                {
                    Console.Write("Введите номер путешествия: ");
                    var journeyNumber = Convert.ToInt32(Console.ReadLine());
                    if (journeyNumber > 0 && journeyNumber <= journeys.Count)
                    {
                        SelectedJourney = journeys[journeyNumber - 1];
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
                        MenuPurchase(ActiveUser);
                        break;
                    case ConsoleKey.D4:
                        MenuInit(ActiveUser);
                        break;
                }
            } while (key != ConsoleKey.D5);
            Input.Main();
        }

    }
}
