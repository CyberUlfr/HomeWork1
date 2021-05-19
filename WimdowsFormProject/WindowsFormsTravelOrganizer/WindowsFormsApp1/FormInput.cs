using ClassLibrary1;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormInput : Form
    {
        public UserPresenter userPresenter;
        public FormInput()
        {
            InitializeComponent();
            UserModel userModel = new UserModel();
            userPresenter = new UserPresenter(this, userModel);
            ListBoxUsersUpdate();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ListBoxUsersUpdate()
        {
            listBoxUsers.Items.Clear();
            foreach (var user in userPresenter.UserGetList())
                listBoxUsers.Items.Add(user);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if ((User)listBoxUsers.SelectedItem != null)
            {
                if (((User)listBoxUsers.SelectedItem).IsAdmin)
                {
                    FormAdmin fA = new FormAdmin();
                    fA.Show();
                }
                else
                {
                    MessageBox.Show("Форма пользователя!");
                }
                Hide();
            }
            else
            {
                MessageBox.Show("Выберите пользователя.");
            }
            ListBoxUsersUpdate();
        }
    }
}
