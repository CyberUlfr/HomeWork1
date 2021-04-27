using System;
using System.Collections.Generic;
using System.Linq;

namespace travelOrganizer
{
    public class Journey
    {
        public static List<Journey> Journeys { get; set; } = new List<Journey>();
        public Dictionary<User, List<Distance>> Distances { get; set; } = new Dictionary<User, List<Distance>>();
        public Dictionary<User, List<Purchase>> Purchases { get; set; } = new Dictionary<User, List<Purchase>>();
        public List<User> Users { get; set; } = new List<User>();
        public bool IsStart { get; private set; }
        public DateTime TimeStart { get; private set; }
        public DateTime TimeFinish { get; private set; }
        public string Name { get; set; }
        public bool AddUser(User user)
        {
            Console.Clear();
            if (IsStart || Users.Contains(user))

            {
                return false;
            }
            else
            {
                Users.Add(user);
                return true;
            }
        }
        public Journey(string name, List<User> Users)
        {
            Name = name;
            Journeys.Add(this);
            foreach (User user in Users)
            {
                Users.Add(user);
                Distances.Add(user, new List<Distance>());
                Purchases.Add(user, new List<Purchase>());
                IsStart = false;
            }
        }
        public double GetAmountOfMoney(User user)
        {
            return Purchases[user].Aggregate(0.0, (sum, next) => sum + next.Price);
        }
        static Journey()
        {
            new Journey("Поездка в артышту");
        }
        public Journey(string name)
        {
            Name = name;
            Journeys.Add(this);
            IsStart = false;
        }
        public Journey()
        {
            Name = "Неизвестное путешествие";
            Journeys.Add(this);
            IsStart = false;
        }
        static public void ListJourney()
        {
            Console.Clear();
            for (int i = 0; i < Journeys.Count; i++)
            {
                Console.WriteLine("{0}:Название путешествия - {1}", i + 1, Journeys[i]);
            }
            Console.WriteLine("Для перехода в меню нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
