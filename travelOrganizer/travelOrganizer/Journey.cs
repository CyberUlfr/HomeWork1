using System;
using System.Collections.Generic;

namespace travelOrganizer
{
    class Journey
    {
        public static Dictionary<int, Journey> Journeys { get; set; } = new Dictionary<int, Journey>();
        public string Name { get; set; }
        public int Number { get; set; }
        public Journey(int number, string name)
        {
            Name = name;
            Number = number;
            Journeys.Add(number, this);
        }
        static public void StartJourney()
        {
            Console.Clear();
            new Journey(1, "Поездка в артышту");
            foreach (KeyValuePair<int, Journey> keyValue in Journeys)
            {
                Console.WriteLine("{0}:Название путешествия - {1}", keyValue.Key, keyValue.Value.Name);
            }
            do
            {
                Console.Write("Введите номер путишествия: ");
                var journeyNumber = Console.ReadLine();
                Menu.MenuRun();
                Console.Clear();
                Console.WriteLine("Пользователь введен неверно.");
            } while (true);
        }
    }
}
