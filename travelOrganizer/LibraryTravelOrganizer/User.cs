using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

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
        public static void Init()
        {
            Users.Add(new User("Админ", true));
            Users.Add(new User("Костя"));
        }
        static public void StartUser()
        {
            Users = DataBase.LoadUsers(Users);
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
                        var users1 = Users.First(username => username == user);
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
    public static class DataBase
    {
        public static string userPath { get; set; } = "C:\\Users\\User\\Desktop\\Учёба в GoodLine\\HomeWork\\travelOrganizer\\Users.txt";
        public static bool SaveUsers(List<User> users)
        {
            StreamWriter fileIn;
            try
            {
                fileIn = new StreamWriter(userPath);
                foreach (var user in users)
                {
                    fileIn.WriteLine(user.Name);
                    fileIn.WriteLine(user.IsAdmin);
                }
                fileIn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка! {ex.Message}");
                return false;
            }
            return true;
        }

        public static List<User> LoadUsers(List<User> users)
        {
            StreamReader fileOut;
            try
            {
                if (File.Exists(userPath))
                {
                    List<User> tempUser = new List<User>();
                    fileOut = new StreamReader(userPath);
                    while (!fileOut.EndOfStream)
                    {
                        string name = fileOut.ReadLine();
                        bool isAdmin = bool.Parse(fileOut.ReadLine());
                        tempUser.Add(new User(name,isAdmin));
                    }
                    fileOut.Close();
                    if (tempUser.Count > 0)
                    {
                        users = tempUser;
                    }
                }
                else
                    throw new Exception("Файла не существует!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка! {ex.Message}");
                return null;
            }
            return users;
        }
    }
}
