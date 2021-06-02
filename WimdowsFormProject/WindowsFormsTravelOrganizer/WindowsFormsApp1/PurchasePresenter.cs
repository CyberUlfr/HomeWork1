using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class PurchasePresenter
    {
        public PurchaseModel pModel;
        public JourneyModel jModel;
        public FormUsers View;
        public PurchasePresenter(FormUsers view, PurchaseModel purchaseModel, JourneyModel journeyModel)
        {
            View = view;
            pModel = purchaseModel;
            jModel = journeyModel;
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
        public void ConvertRubInDollar(Purchase purchase)
        {
            try
            {
                double dollar = pModel.ConvertRubInDollar(purchase);
                MessageBox.Show($"Стоймость продукта в долларах = {dollar:N2} usd.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
                return;
            }
        }
        public List<Purchase> SortedIncrease()
        {
            return pModel.SortedIncrease();
        }
        public List<Purchase> SortedDescending()
        {
            return pModel.SortedDescending();
        }
        public double StatisticPurchase()
        {
            double sum = pModel.PurchaseStatistic();
            return sum;
        }
        public DateTime TimeStart()
        {
            return jModel.SelectedJourney.TimeStart;
        }
        public int TimeAll()
        {
            return (int)(DateTime.Now - jModel.SelectedJourney.TimeStart).TotalSeconds;
        }
        
    }
}

