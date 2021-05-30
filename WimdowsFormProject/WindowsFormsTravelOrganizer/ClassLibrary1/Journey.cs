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
        public Journey(string name, List<User> users)
        {
            Name = name;
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
        public Journey SelectedJourney;
        public List<User> Users = new List<User>();
        public JourneyModel(UserModel userModel)
        {
            Journeys.Add(new Journey("Поездка в артышту", userModel.Users));
            Journeys.Last().Start();
        }
        public void JourneyAdd(string journey, List<User> users)
        {
            if (Journeys.Any(u => u.Name == journey))
                throw (new Exception("Данное путешествие уже существует!"));
            Journeys.Add(new Journey(journey, users));
        }
        public void UserAddJourney(User user)
        {
            if (Users.Any(u => u.Name == user.Name))
                throw new Exception("Данный пользователь уже существует!");
            Users.Add(user);
        }
        public void UserRemoveJourney(User user)
        {
            Users.Remove(user);
        }
        public List<Journey> JourneyEdit(int index, string name)
        {
            Journeys[index].Name = name;
            return Journeys;
        }
        public void JourneyRemove(Journey journey)
        {
            Journeys.Remove(journey);
        }
        public List<Journey> GetUserJourneys(User user)
        {
            List<Journey> journeys = new List<Journey>();
            foreach (var journey in Journeys)
            {
                if (journey.Users.Contains(user))
                    journeys.Add(journey);
            }
            return journeys;
        }
        
    }
}
