using ClassLibrary1;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormAdmin : Form
    {
        public UserPresenterAdmin userPresenterAdmin;
        public JourneyPresenter journeyPresenter;
        public FormAdmin()
        {
            InitializeComponent();
            JourneyModel journeyModel = new JourneyModel();
            UserModel userModel = new UserModel();
            userPresenterAdmin = new UserPresenterAdmin(this, userModel);
            journeyPresenter = new JourneyPresenter(this, journeyModel, userModel);
            ListBoxUsersUpdate();
            ListBoxJourneysUpdate();
        }

        private void listBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            if (textBoxUserName.Text.Trim() == "" || textBoxUserName.Text.Trim() == "")
            {
                MessageBox.Show("Поле не заполнено!");
                return;
            }
            string name = textBoxUserName.Text.Trim();
            userPresenterAdmin.UserAdd(name);
            ListBoxUsersUpdate();
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
    }
}
