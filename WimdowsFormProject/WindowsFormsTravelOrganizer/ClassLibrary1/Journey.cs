using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Journey
    {
        public List<User> Users { get; private set; } = new List<User>();
        public bool IsStart { get; private set; }
        public DateTime TimeStart { get; private set; }
        public DateTime TimeFinish { get; private set; }
        public string Name { get; set; }
        public bool AddUser(User user)
        {
            Console.Clear();
            if (IsStart || Users.Contains(user) || TimeFinish.Ticks > 0)
            {
                return false;
            }
            else
            {
                Users.Add(user);
                return true;
            }
        }
        public Journey(string name, List<User> users)
        {
            Name = name;
            foreach (User user in users.ToArray())
            {
                Users.Add(user);
                IsStart = false;
            }
        }
        public bool Start()
        {
            if (IsStart)
            {
                return false;
            }
            IsStart = true;
            TimeStart = DateTime.Now;
            return true;
        }
        public bool Finish()
        {
            if (!IsStart)
            {
                return false;
            }
            TimeFinish = DateTime.Now;
            return true;
        }
        public Journey(string name)
        {
            Name = name;
            IsStart = false;
        }
        public Journey()
        {
            Name = "Неизвестное путешествие";
            IsStart = false;
        }
        public override string ToString()
        {
            return string.Format($"{Name}");
        }
    }
    public class JourneyModel
    {
        public List<Journey> Journeys = new List<Journey>();
        public JourneyModel()
        {
            Journeys.Add(new Journey("Поездка в артышту", new List<User>()));
            Journeys.Last().Start();
        }
        public void JourneyAdd(string name, string users)
        {
            if (Journeys.Any(u => u.Name == name))
                throw (new Exception("Данное путешествие уже существует!"));
            new Journey(name, users);
        }
        public List<Journey> JourneyEdit(int index, string name)
        {
            Journeys[index].Name = name;
            return Journeys;
        }
        public List<Journey> JourneyRemove(Journey journey)
        {
            Journeys.Remove(journey);
            return Journeys;
        }

    }
}
