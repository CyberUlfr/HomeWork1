using System;
using System.Collections.Generic;
using System.Linq;

namespace travelOrganizer
{
    public class User
    {
        public static List<User> Users { get; set; } = new List<User>();
        public string Name { get; set; }
        public User(string name)
        {
            Name = name;
            Users.Add(this);
        }
        static User()
        {
            new User("Костя");
            new User("Кирилл");
        }
        static public void StartUser()
        {
            Console.Clear();
            foreach (var user in User.Users)
            {
                Console.WriteLine("Список пользователей = {0}", user.Name);
            }
            do
            {
                Console.Write("Введите имя пользователя: ");
                var userName = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(userName) && Users.Any(user => user.Name == userName))
                {
                    Journey.StartJourney();
                }
                Console.Clear();
                Console.WriteLine("Пользователь введен неверно.");
            } while (true);
        }
    }
}
