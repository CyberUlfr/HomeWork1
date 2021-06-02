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
        public FormSelectJourney(JourneyModel jModel ,UserModel uModel)
        {
            InitializeComponent();
            MaximizeBox = false;
            selectJourneyPresenter = new SelectJourneyPresenter(this, jModel, uModel);
            labelSelectJourney.Text = "Привет, " + selectJourneyPresenter.GetActiveUser() + ". Выбирите путешествие.";
            ComboBoxSelectJourneyUpdate();
        }
        private void ComboBoxSelectJourneyUpdate()
        {
            comboBoxSelectJourney.Items.Clear();
            foreach (var journey in selectJourneyPresenter.UserGetListJourney())
                comboBoxSelectJourney.Items.Add(journey);
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if ((Journey)comboBoxSelectJourney.SelectedItem != null)
            {
                selectJourneyPresenter.SelectJourney((Journey)comboBoxSelectJourney.SelectedItem);
                Hide();
            }
            else
            {
                MessageBox.Show("Выберите путешествие!");
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close();
        }
    }
}
