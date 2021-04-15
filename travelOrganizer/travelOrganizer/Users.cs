using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace travelOrganizer
{
    class Users
    {
        static public void StartUser()
        {
            Console.Clear();
            List<string> userList = new List<string>();
            userList.Add("Костя");
            userList.Add("Кирилл");
            foreach (var list in userList)
            {
                Console.WriteLine("Список пользователей = {0}", list);
            }
            do
            {
                Console.Write("Введите имя пользователя: ");
                var userName = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(userName) && userList.Contains(userName))
                {
                    Menu.MenuRun();
                }
                Console.Clear();
                Console.WriteLine("Пользователь введен неверно.\r\n", ConsoleColor.DarkRed);
            } while (true);
        }
    }
}
