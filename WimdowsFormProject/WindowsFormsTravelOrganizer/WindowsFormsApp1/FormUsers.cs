using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace WindowsFormsApp1
{
    public partial class FormUsers : Form
    {
        public PurchasePresenter purchasePresenter;
        public DistancePresenter distancePresenter;
        public FormUsers(JourneyModel jModel, UserModel uModel)
        {
            InitializeComponent();
            PurchaseModel purchaseModel = new PurchaseModel(jModel.SelectedJourney.Purchases[uModel.ActiveUser]);
            DistanceModel distanceModel = new DistanceModel(jModel.SelectedJourney.Distances[uModel.ActiveUser]);
            purchasePresenter = new PurchasePresenter(this, purchaseModel, jModel);
            distancePresenter = new DistancePresenter(this, distanceModel);
            ListBoxPurchaseUpdate();
            ListBoxDistanceUpdate();
            labelStatisticDistanceUpdate();
            labelStatisticPurchaseUpdate();
            labelStatisticlabelTimeStartUpdate();
            labelStatisticlabelTimeAllUpdate();
        }
        private void labelStatisticPurchaseUpdate()
        {
            labelStatisticPurchase.Text = "Вы потратили " + purchasePresenter.StatisticPurchase() + " руб.";
        }
        private void labelStatisticDistanceUpdate()
        {
            labelStatisticDistance.Text = "и прошли " + distancePresenter.StatisticDistance() + " км. В этом путешествии.";
        }
        private void labelStatisticlabelTimeStartUpdate()
        {
            labelTimeStart.Text = "Время начала путешествия: " + purchasePresenter.TimeStart();
        }
        private void labelStatisticlabelTimeAllUpdate()
        {
            labelTimeAll.Text = "Общее время путешествия: " + purchasePresenter.TimeAll() + " сек.";
        }
        private void ListBoxDistanceUpdate()
        {
            listBoxDistance.Items.Clear();
            foreach (var distance in distancePresenter.DistanceGetList())
                listBoxDistance.Items.Add(distance);
        }
        private void ListBoxPurchaseUpdate()
        {
            listBoxPurchase.Items.Clear();
            foreach (var purchase in purchasePresenter.PurchaseGetList())
                listBoxPurchase.Items.Add(purchase);
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            Application.OpenForms[2].Close();
        }

        private void buttonAddPurchase_Click(object sender, EventArgs e)
        {
            double price = 0;
            if (textBoxPricePurchase.Text.Trim() == "" || textBoxNamePurchase.Text.Trim() == "")
            {
                MessageBox.Show("Не все поля заполнены!", "Ошибка!");
                return;
            }
            if (!double.TryParse(textBoxPricePurchase.Text, out price))
            {
                MessageBox.Show("Не получилось прочесть возраст!", "Ошибка!");
                return;
            }
            string purchase = textBoxNamePurchase.Text.Trim();
            purchasePresenter.AddPurchase(purchase, price);
            labelStatisticPurchaseUpdate();
            ListBoxPurchaseUpdate();
        }

        private void buttonDeleatePurchase_Click(object sender, EventArgs e)
        {
            if ((Purchase)listBoxPurchase.SelectedItem == null)
            {
                MessageBox.Show("Выберите продукт для удаления!");
                return;
            }
            purchasePresenter.RemovePurchase((Purchase)listBoxPurchase.SelectedItem);
            ListBoxPurchaseUpdate();
            labelStatisticPurchaseUpdate();
        }

        private void listBoxPurchase_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSumPurchase_Click(object sender, EventArgs e)
        {
            purchasePresenter.GetSum();
        }

        private void buttonRubInDollar_Click(object sender, EventArgs e)
        {
            if ((Purchase)listBoxPurchase.SelectedItem == null)
            {
                MessageBox.Show("Выберите продукт для перевода рублей в доллары!");
                return;
            }
            purchasePresenter.ConvertRubInDollar((Purchase)listBoxPurchase.SelectedItem);
        }

        private void buttonSortedIncrease_Click(object sender, EventArgs e)
        {
            listBoxPurchase.Items.Clear();
            foreach (var purchase in purchasePresenter.SortedIncrease())
                listBoxPurchase.Items.Add(purchase);
        }

        private void buttonSortedDescending_Click(object sender, EventArgs e)
        {
            listBoxPurchase.Items.Clear();
            foreach (var purchase in purchasePresenter.SortedDescending())
                listBoxPurchase.Items.Add(purchase);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBoxDistance_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddDistance_Click(object sender, EventArgs e)
        {
            double kmeters = 0;
            if (textBoxKMetersDistance.Text.Trim() == "" || textBoxNameDistance.Text.Trim() == "")
            {
                MessageBox.Show("Не все поля заполнены!", "Ошибка!");
                return;
            }
            if (!double.TryParse(textBoxKMetersDistance.Text, out kmeters))
            {
                MessageBox.Show("Не получилось прочесть расстояние!", "Ошибка!");
                return;
            }
            string distance = textBoxNameDistance.Text.Trim();
            distancePresenter.AddDistance(distance, kmeters);
            ListBoxDistanceUpdate();
            labelStatisticDistanceUpdate();
        }

        private void textBoxKMetersDistance_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonRemoveDistance_Click(object sender, EventArgs e)
        {
            if ((Distance)listBoxDistance.SelectedItem == null)
            {
                MessageBox.Show("Выберите передвижение для удаления!");
                return;
            }
            distancePresenter.RemoveDistance((Distance)listBoxDistance.SelectedItem);
            ListBoxDistanceUpdate();
            labelStatisticDistanceUpdate();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void labelStatisticPurchase_Click(object sender, EventArgs e)
        {

        }

        private void labelStatisticDistance_Click(object sender, EventArgs e)
        {

        }

        private void labelStatistic_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdateTime_Click(object sender, EventArgs e)
        {
            labelStatisticlabelTimeAllUpdate();
        }
    }
}
