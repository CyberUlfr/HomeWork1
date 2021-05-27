using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormSelectJourney : Form
    {
        public SelectJourneyPresenter selectJourneyPresenter;
        public FormSelectJourney(List<Journey> Journeys, User user)
        {
            InitializeComponent();
            JourneyModel journeyModel = new JourneyModel();
            UserModel userModel = new UserModel();
            selectJourneyPresenter = new SelectJourneyPresenter(this, journeyModel, userModel);
            labelSelectJourney.Text = "Привет, " + user + ". Выбирите путешествие.";
            ComboBoxSelectJourneyUpdate();
        }
        private void ComboBoxSelectJourneyUpdate()
        {
            comboBoxSelectJourney.Items.Clear();
            foreach (var users in selectJourneyPresenter.UserGetListJourney())
                comboBoxSelectJourney.Items.Add(users);
        }
        private void comboBoxSelectJourney_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if ((Journey)comboBoxSelectJourney.SelectedItem!= null)
            {
                SelectedJourney = (Journey)comboBoxSelectJourney.SelectedItem;
                DialogResult = DialogResult.OK;
                FormUsers fU = new FormUsers();
                fU.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Выберите путешествие!");
                return;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            Application.OpenForms[1].Close();
        }

        private void labelSelectJourney_Click(object sender, EventArgs e)
        {
        }
    }
}
