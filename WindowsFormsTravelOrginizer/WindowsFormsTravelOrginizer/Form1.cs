using System;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using travelOrganizer;

namespace WindowsFormsTravelOrginizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void listBoxSelectedName(object sender, EventArgs e)
        {
            
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            listBoxUsers.Items.Clear();
            foreach (var user in travelOrganizer.User.Users)
                listBoxUsers.Items.Add(user.Name);
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void buttonUsersSelect_Click(object sender, EventArgs e)
        {
            foreach (var user in travelOrganizer.User.Users)
            {
                if (!user.IsAdmin)
                {
                    tabSelectUser.SelectedIndex = 1;
                }
                else
                {
                    tabSelectUser.SelectedIndex = 2;
                }
            }
        }

        private void tabUsers_Click(object sender, EventArgs e)
        {

        }

        private void tabMenuAdmin_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listBoxMenuAdminUsers.Items.Clear();
            foreach (var user in travelOrganizer.User.Users)
                listBoxMenuAdminUsers.Items.Add(user.Name);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (textBoxUser.Text.Trim() == "")
            {
                MessageBox.Show("Не все поля заполнены!", "Ошибка!");
                return;
            }
            string userName = textBoxUser.Text.Trim();
            User.Users.Add(new User(userName));
        }
        private void buttonDeleateUser_Click(object sender, EventArgs e)
        {
            if ((User)listBoxMenuAdminUsers.SelectedItem == null)
            {
                MessageBox.Show("Выберите пользователя для удаления!", "Ошибка выбора!");
                return;
            }
            User.Users.Remove((User)listBoxMenuAdminUsers.SelectedItem);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
