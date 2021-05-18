using System;
using System.Windows.Forms;
using travelOrganizer;
using WindowsFormsTravelOrginizer;

namespace LibraryTravelOrganizer
{
    public partial class FormInput : Form
    {
        public FormInput()
        {
            User.Init();
            InitializeComponent();
            ListBoxUsersEditUpdate();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var user in User.Users)
                if (user.IsAdmin)
            {
                Form1 f = new Form1();
                f.Show();
            }
            else
            {
                FormUsers fUsers = new FormUsers();
                fUsers.Show();
            }
            this.Hide();
            ListBoxUsersEditUpdate();
        }
        private void ListBoxUsersEditUpdate()
        {
            listBoxUsers2.Items.Clear();
            foreach (var user in User.Users)
                listBoxUsers2.Items.Add(user.Name);
        }
    }
}
