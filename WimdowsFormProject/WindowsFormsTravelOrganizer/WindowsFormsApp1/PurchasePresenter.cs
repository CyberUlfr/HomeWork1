using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
        public List<Purchase> PurchaseGetList()
        {
            return pModel.Purchases;
        }
        public void GetSum()
        {
            try
            {
                double sum = pModel.GetSum();
                MessageBox.Show($"Сумма всех продуктов = {sum:N2} руб.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
                return;
            }
        }
        public void ConvertRubInDollar()
        {
            try
            {
                double dollar = pModel.ConvertRubInDollar();
                MessageBox.Show($"Его стоймость в долларах = {dollar:N2} usd.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
                return;
            }
        }
    }
}

