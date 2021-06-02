using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace ClassLibrary1
{
    public class UserDataBase
    {
        public static SqlConnection sqlConnection = new SqlConnection(
            "Data Source=LAPTOP-MGTH31CQ\\SQLEXPRESS;Initial Catalog=MyDataBaseOrganizer;Integrated Security=True");
        public static List<User> DataBaseLoad()
        {
            List<User> users = new List<User>();
            string sql = "SELECT name, isAdmin FROM Table_users";
            SqlCommand command = new SqlCommand(sql, sqlConnection);
            sqlConnection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string name = reader.GetString(0);
                    bool isAdmin = reader.GetBoolean(1);
                    users.Add(new User(name, isAdmin));
                }
            }
            sqlConnection.Close();
            return users;
        }
        public static void DataBaseSave(List<User> users)
        {
            string sql = "DELETE FROM Table_users";
            SqlCommand command = new SqlCommand(sql, sqlConnection);
            sqlConnection.Open();
            try
            {
                command.ExecuteNonQuery();
                sql = "INSERT Table_users VALUES";
                foreach (var user in users)
                {
                    if (user.IsAdmin)
                    {
                        if (sql[sql.Length - 1] == ')')
                            sql += ",";
                        sql += $" ('{user.Name}', {1})";
                    }
                    else
                    {
                        if (sql[sql.Length - 1] == ')')
                            sql += ",";
                        sql += $" ('{user.Name}', {0})";
                    }
                }
                command = new SqlCommand(sql, sqlConnection);
                command.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                throw (new Exception("Ошибка при сохранении!"));
            }
            sqlConnection.Close();
        }
        public static void DataBaseUserDelete(User user)
        {
            string sql = $"DELETE FROM Table_users WHERE name = '{user.Name}'";
            SqlCommand command = new SqlCommand(sql, sqlConnection);
            sqlConnection.Open();
            int DeletedCount = command.ExecuteNonQuery();
            sqlConnection.Close();
            if (DeletedCount > 1)
                throw (new Exception("Удалили больше 1 юзера!"));
            else if (DeletedCount == 0)
                throw (new Exception("Юзера нет в базе данных!"));
        }
    }
    public class JourneysDataBase
    {

    }
}
