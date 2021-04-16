using System;
using System.Collections.Generic;
using System.Linq;

namespace travelOrganizer
{
    class User
    {
        public static List<User> Users { get; set; } = new List<User>();
        public string Name { get; set; }
        public User(string name)
        {
            Name = name;
            Users.Add(this);
        }
        static public void StartUser()
        {
            Console.Clear();
            new User("Костя");
            new User("Кирилл");
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
                    Menu.MenuRun();
                }
                Console.Clear();
                Console.WriteLine("Пользователь введен неверно.");
            } while (true);
        }
    }
}
