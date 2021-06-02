using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using ClassLibrary1;

namespace WindowsFormsApp1
{
    public class UserPresenterAdmin
    {
        public UserModel model;
        public FormAdmin View;
        public UserPresenterAdmin(FormAdmin view, UserModel userModel)
        {
            View = view;
            model = userModel;
        }
        public void UserAdd(string name)
        {
            try
            {
                if (name.Trim() != "")
                {
                    model.UserAdd(name);
                }
                else
                {
                    MessageBox.Show("Ошибка! Данные введены не верно!", "Ошибка!");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
                return;
            }
        }
        public List<User> UserGetListA()
        {
            return model.Users;
        }
        public void UserEdit(int index, string name)
        {
            try
            {
                if (name.Trim() != "" && index >= 0)
                    model.UserEdit(index, name);
                else
                {
                    MessageBox.Show("Ошибка! Данные введены не верно!", "Ошибка!");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
                return;
            }
        }
        public void UserRemove(User user)
        {
            if (!user.IsAdmin)
            {
                model.UserRemove(user);
            }
            else
            {
                MessageBox.Show("Ошибка! Нельзя удалять админа!");
            }    
        }
    }
}
