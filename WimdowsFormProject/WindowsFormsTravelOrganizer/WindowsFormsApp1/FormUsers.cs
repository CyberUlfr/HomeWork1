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
            MaximizeBox = false;
            PurchaseModel purchaseModel = new PurchaseModel(jModel.SelectedJourney.Purchases[uModel.ActiveUser]);
            DistanceModel distanceModel = new DistanceModel(jModel.SelectedJourney.Distances[uModel.ActiveUser]);
            purchasePresenter = new PurchasePresenter(this, purchaseModel, jModel, uModel);
            distancePresenter = new DistancePresenter(this, distanceModel);
            labelNameUser.Text = "Вы вошли как " + purchasePresenter.GetActiveUser() + ".";
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

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Application.Exit();
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close();
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

        private void buttonUpdateTime_Click(object sender, EventArgs e)
        {
            labelStatisticlabelTimeAllUpdate();
        }

    }
}
