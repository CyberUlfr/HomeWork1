using System;
using System.Collections.Generic;
using System.Linq;

namespace travelOrganizer
{
    class Journey
    {
        public static Dictionary<int, Journey> Journeys { get; set; } = new Dictionary<int, Journey>();
        public string Name { get; set; }
        public static int GetFirstFreeNumber()
        {
            int number = 1;
            foreach (var journey in Journey.Journeys.OrderBy(j => j.Key))
                if (journey.Key == number)
                    number++;
            return number;
        }
        static Journey()
        {
            new Journey("Поездка в артышту");
        }
        public Journey(string name)
        {
            Name = name;
            Journeys.Add(GetFirstFreeNumber(), this);
        }
        static public void StartJourney()
        {
            Console.Clear();
            foreach (KeyValuePair<int, Journey> keyValue in Journeys)
            {
                Console.WriteLine("{0}:Название путешествия - {1}", keyValue.Key, keyValue.Value.Name);
            }
            do
            {
                Console.Write("Введите номер путишествия: ");
                int journeyNumber = Convert.ToInt32(Console.ReadLine());
                if (Journeys.ContainsKey(journeyNumber))
                {
                    Menu.MenuRun();
                }
                Console.Clear();
                Console.WriteLine("Номер путишествия введен неверно.");
            } while (true);
        }
    }
}
