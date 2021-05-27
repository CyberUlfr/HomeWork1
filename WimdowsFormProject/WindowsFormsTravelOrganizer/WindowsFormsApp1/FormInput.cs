using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormInput : Form
    {
        public UserPresenter userPresenter;
        public FormInput(List<Journey> Journeys, User user)
        {
            InitializeComponent();
            UserModel userModel = new UserModel();
            JourneyModel journeyModel = new JourneyModel();
            userPresenter = new UserPresenter(this, journeyModel, userModel);
            FormSelectJourney fSJ = new FormSelectJourney(Journeys, user);
            if (fSJ.DialogResult == DialogResult.OK)
            {
                userPresenter.SelectedJourney = fSJ.SelectedJourney;
            }
            ListBoxUsersUpdate();
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
            Application.Exit();
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
                    FormInput.fSJ.Show();
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
