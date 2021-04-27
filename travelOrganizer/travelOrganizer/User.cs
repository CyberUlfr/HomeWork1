using System;
using System.Collections.Generic;
using System.Linq;

namespace travelOrganizer
{
    public class User
    {
        public static List<User> Users { get; set; } = new List<User>();
        public string Name { get; set; }
        public bool IsAdmin { get; set; }
        public User() { Name = "Без имени"; IsAdmin = false; Users.Add(this); }
        public User(string name)
        {
            Name = name;
            Users.Add(this);
            IsAdmin = false;
        }
        internal User(string name, bool isAdmin)
        {
            Name = name;
            IsAdmin = isAdmin;
            Users.Add(this);
        }
        static User()
        {
            new User("Админ", true);
            new User("Костя");
        }
        static public void StartUser()
        {
            Console.Clear();
            foreach (var user in Users)
            {
                Console.WriteLine("Список пользователей = {0}", user.Name);
            }
            do
            {
                Console.Write("Введите имя пользователя: ");
                var userName = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(userName) && Users.Any(user => user.Name == userName))
                {
                    Console.Clear();
                    var user = Users.First(username => username.Name == userName);
                    if (!user.IsAdmin)
                    {
                        var users = Users.First(username => username == user);
                        Menu.MenuRun();
                    }
                    else
                    {
                        var admin = Users.First(username => username == user);
                        AdminMenu.MenuAdmin();
                    }
                    Console.Clear();
                    Console.WriteLine("Пользователь введен неверно.");
                }
            } while (true);
        }
    }
}
