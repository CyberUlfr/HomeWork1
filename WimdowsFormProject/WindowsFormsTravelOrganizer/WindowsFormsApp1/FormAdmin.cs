using ClassLibrary1;
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace WindowsFormsApp1
{
    public partial class FormAdmin : Form
    {
        public UserPresenterAdmin userPresenterAdmin;
        public JourneyPresenter journeyPresenter;
        public FormAdmin()
        {
            InitializeComponent();
            UserModel userModel = new UserModel();
            JourneyModel journeyModel = new JourneyModel(userModel);
            userPresenterAdmin = new UserPresenterAdmin(this, userModel);
            journeyPresenter = new JourneyPresenter(this, journeyModel, userModel);
            ListBoxUsersUpdate();
            ComboBoxUsersUpdate();
            ListBoxJourneysUpdate();
            ListBoxUsersAddJourneyUpdate();
        }
        private void listBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ListBoxUsersAddJourneyUpdate()
        {
            listBoxUsersAdd.Items.Clear();
            foreach (var users in journeyPresenter.UserJGetList())
                listBoxUsersAdd.Items.Add(users);
        }
        private void ComboBoxUsersUpdate()
        {
            comboBoxAddUsers.Items.Clear();
            foreach (var users in userPresenterAdmin.UserGetListA())
                comboBoxAddUsers.Items.Add(users);
        }
        private void ListBoxJourneysUpdate()
        {
            listBoxJourneys.Items.Clear();
            foreach (var journey in journeyPresenter.UserGetListJourney())
                listBoxJourneys.Items.Add(journey);
        }
        private void ListBoxUsersUpdate()
        {
            listBoxUsers.Items.Clear();
            foreach (var user in userPresenterAdmin.UserGetListA())
                listBoxUsers.Items.Add(user);
        }
        private void buttonUserAdd_Click(object sender, EventArgs e)
        {
            if (textBoxUserName.Text.Trim() == "")
            {
                MessageBox.Show("Поле не заполнено!");
                return;
            }
            string name = textBoxUserName.Text.Trim();
            userPresenterAdmin.UserAdd(name);
            ListBoxUsersUpdate();
            ComboBoxUsersUpdate();
        }
        private void buttonEditUsers_Click(object sender, EventArgs e)
        {
            if ((User)listBoxUsers.SelectedItem == null)
            {
                MessageBox.Show("Выберите пользователя для редактирования!");
                return;
            }
            User user = (User)listBoxUsers.SelectedItem;
            if (textBoxUserName.Text.Trim() == "" || textBoxUserName.Text.Trim() == "")
            {
                MessageBox.Show("Поле не заполнено!");
                return;
            }
            string name = textBoxUserName.Text.Trim();
            user.Name = name;
            userPresenterAdmin.UserEdit(listBoxUsers.SelectedIndex, name);
            ListBoxUsersUpdate();
        }

        private void buttonDeleateUser_Click(object sender, EventArgs e)
        {
            if ((User)listBoxUsers.SelectedItem == null)
            {
                MessageBox.Show("Выберите пользователя для удаления!");
                return;
            }
            userPresenterAdmin.UserRemove((User)listBoxUsers.SelectedItem);
            ListBoxUsersUpdate();
        }

        private void listBoxJourneys_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void labelJourneys_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddJourneys_Click(object sender, EventArgs e)
        {
            if (textBoxJourneys.Text.Trim() == "")
            {
                MessageBox.Show("Поле не заполнено!");
                return;
            }
            string name = textBoxJourneys.Text.Trim();
            List<User> users = new List<User>();
            foreach (User user in listBoxUsersAdd.Items)
                users.Add(user);
            journeyPresenter.JourneyAdd(name, users);
            ListBoxJourneysUpdate();
            ListBoxUsersAddJourneyUpdate();
        }

        private void textBoxJourneys_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxAddUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxUsersAdd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddUsersJourneys_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxAddUsers.Text))
            {
                MessageBox.Show("Поле не заполнено!");
                return;
            }
            var user = (User)comboBoxAddUsers.SelectedItem;
            journeyPresenter.UserAddJourney(user);
            ListBoxUsersAddJourneyUpdate();
        }

        private void buttonRemoveJourneys_Click(object sender, EventArgs e)
        {
            if ((Journey)listBoxJourneys.SelectedItem == null)
            {
                MessageBox.Show("Выберите путешествие для удаления!");
                return;
            }
            journeyPresenter.JourneyRemove((Journey)listBoxJourneys.SelectedItem);
            ListBoxJourneysUpdate();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            Application.OpenForms[1].Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((User)listBoxUsersAdd.SelectedItem == null)
            {
                MessageBox.Show("Выберите пользователя для удаления!");
                return;
            }
            journeyPresenter.UserRemoveJourney((User)listBoxUsersAdd.SelectedItem);
            ListBoxUsersAddJourneyUpdate();
        }
    }
}
