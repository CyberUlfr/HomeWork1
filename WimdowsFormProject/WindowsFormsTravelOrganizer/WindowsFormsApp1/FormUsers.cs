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
            PurchaseModel purchaseModel = new PurchaseModel();
            purchasePresenter = new PurchasePresenter(this, purchaseModel);
            InitializeComponent();
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
            Application.OpenForms[1].Close();
        }

        private void buttonAddPurchase_Click(object sender, EventArgs e)
        {

        }
    }
}
