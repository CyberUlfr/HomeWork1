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
        public User() { Name = "Без имени"; IsAdmin = false; }
        public User(string name)
        {
            Name = name;
            IsAdmin = false;
        }
        internal User(string name, bool isAdmin)
        {
            Name = name;
            IsAdmin = isAdmin;
        }
        static User()
        {
            Users.Add(new User("Админ", true));
            Users.Add(new User("Костя"));
        }
        static public void StartUser()
        {
            do
            {
                Console.Clear();
                foreach (var user in Users)
                {
                    Console.WriteLine("Список пользователей = {0}", user.Name);
                }
                Console.Write("Введите имя пользователя: ");
                var userName = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(userName) && Users.Any(user => user.Name == userName))
                {
                    Console.Clear();
                    var user = Users.First(username => username.Name == userName);
                    if (!user.IsAdmin)
                    {
                        var users = Users.First(username => username == user);
                        Menu.MenuRun(user);
                    }
                    else
                    {
                        var admin = Users.First(username => username == user);
                        AdminMenu.MenuAdmin(admin);
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Пользователь введен неверно. Нажмите любую клавишу чтобы вернуться в меню входа.");
                    Console.ReadKey();
                    return;
                }
            } while (true);
        }
    }
}
