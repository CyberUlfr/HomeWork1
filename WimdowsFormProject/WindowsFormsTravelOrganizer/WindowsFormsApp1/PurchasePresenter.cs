using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using ClassLibrary1;
using System.Collections.Generic;
using System;
using System.Linq;

namespace WindowsFormsApp1
{
    public class PurchasePresenter
    {
        public PurchaseModel pModel;
        public FormUsers View;
        public PurchasePresenter(FormUsers view, PurchaseModel purchaseModel)
        {
            View = view;
            pModel = purchaseModel;
        }
        public void AddPurchase(string name, double price)
        {
            try
            {
                pModel.AddPurchase(name, price);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
                return;
            }
        }
        public void RemovePurchase(Purchase purchase)
        {
            pModel.RemovePurchase(purchase);
        }
    }
}
