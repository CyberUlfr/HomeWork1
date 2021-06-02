using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary1
{
    public class User
    {
        public string Name { get; set; }
        public bool IsAdmin { get; set; }

        public User()
        {
            Name = "Без имени";
            IsAdmin = false;
        }
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
        public override string ToString()
        {
            return $"{Name}";
        }
    }
    public class UserModel
    {
        public List<User> Users = new List<User>();
        public User ActiveUser;
        public UserModel()
        {
            Users = UserDataBase.DataBaseLoad();
        }
        public void UserInit()
        {
            Users.Add(new User("Админ", true));
            Users.Add(new User("Костя"));
        }
        public void UserAdd(string name)
        {
            if (Users.Any(u => u.Name == name))
                throw new Exception("Данный пользователь уже существует!");
            Users.Add(new User(name));
            UserDataBase.DataBaseSave(Users);
        }
        public List<User> UserEdit(int index, string name)
        {
            Users[index].Name = name;
            return Users;
        }
        public List<User> UserRemove(User user)
        {
            Users.Remove(user);
            UserDataBase.DataBaseUserDelete(user);
            return Users;
        }
        public void SelectUser (User user)
        {
            if (Users.Contains(user))
                ActiveUser = user;
            else
                throw (new Exception("Выбранный пользователь не существует в списке!"));
        }
    }
}
