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
        public FormUsers()
        {
            InitializeComponent();
            PurchaseModel purchaseModel = new PurchaseModel();
            purchasePresenter = new PurchasePresenter(this, purchaseModel);
            ListBoxPurchaseUpdate();
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
            purchasePresenter.ConvertRubInDollar();
        }
    }
}
