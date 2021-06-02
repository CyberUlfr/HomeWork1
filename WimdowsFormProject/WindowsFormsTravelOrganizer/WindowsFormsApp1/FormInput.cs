using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormInput : Form
    {
        public UserPresenter userPresenter;
        public FormInput()
        {
            InitializeComponent();
            MaximizeBox = false;
            UserModel userModel = new UserModel();
            JourneyModel journeyModel = new JourneyModel(userModel);
            userPresenter = new UserPresenter(this, journeyModel, userModel);
            ListBoxUsersUpdate();
        }
        private void ListBoxUsersUpdate()
        {
            listBoxUsers.Items.Clear();
            foreach (var user in userPresenter.UserGetList())
                listBoxUsers.Items.Add(user);
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if ((User)listBoxUsers.SelectedItem != null)
            {
                userPresenter.SelectUser((User)listBoxUsers.SelectedItem);
            }
            else
            {
                MessageBox.Show("Выберите пользователя.");
            }
            ListBoxUsersUpdate();
        }
    }
}
