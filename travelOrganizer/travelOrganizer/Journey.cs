using System;
using System.Collections.Generic;
using System.Linq;

namespace travelOrganizer
{
    class Journey
    {
        public static Dictionary<int, Journey> Journeys { get; set; } = new Dictionary<int, Journey>();
        public Dictionary<User, List<Distance>> Distance { get; set; } = new Dictionary<User, List<Distance>>();
        public Dictionary<User, List<Purchase>> Purchases { get; set; } = new Dictionary<User, List<Purchase>>();
        public List<User> Users { get; set; } = new List<User>();
        
        public string Name { get; set; }
        readonly DateTime TimeStart;
        readonly DateTime TimeFinish;
        
        public double GetAmountOfMoney(User user)
        {
            return Purchases[user].Aggregate(0.0, (sum, next) => sum + next.Price);
        }
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
        public Journey()
        {
            User.Add(this);
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
                Console.Write("Введите номер путешествия: ");
                int journeyNumber = Convert.ToInt32(Console.ReadLine());
                if (Journeys.ContainsKey(journeyNumber))
                {
                    Menu.MenuRun();
                }
                Console.Clear();
                Console.WriteLine("Номер путешествия введен неверно.");
            } while (true);
        }
    }
}
