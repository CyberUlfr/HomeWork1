using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary1
{
    public class Purchase
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Purchase() { Name = "Без имени"; Price = 0; }
        public Purchase(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public override string ToString()
        {
            return string.Format($"Продукт {Name} стоит {Price} руб.");
        }
    }
    public class PurchaseModel
    {
        public List<Purchase> Purchases = new List<Purchase>();
        public void AddPurchase(string purchase, double price)
        {
            if (Purchases.Any(u => u.Name == purchase))
                throw (new Exception("Данный продукт уже добавлен!"));
            Purchases.Add(new Purchase(purchase, price));
        }
        public void RemovePurchase(Purchase purchase)
        {
            Purchases.Remove(purchase);
        }
        public double GetSum()
        {
            if (Purchases.Count == 0)
                throw (new Exception("Список пуст."));
            else
            {
                double sum = Purchases.Sum(elem => elem.Price);
                return sum;
            }
        }
        public double ConvertRubInDollar(Purchase purchase)
        {
            double dollar = purchase.Price / 77;
                return dollar;
        }
        public List<Purchase> SortedIncrease()
        {
            List<Purchase> purchases = new List<Purchase>();
            if (Purchases.Count == 0)
                throw (new Exception("Список пуст."));
            else
            {
                var sortedPrice = Purchases.OrderBy(elem => elem.Price);
                foreach (Purchase elem in sortedPrice)
                {
                    purchases.Add(elem);
                }
                return purchases;
            }
        }
        public List<Purchase> SortedDescending()
        {
            List<Purchase> purchases = new List<Purchase>();
            if (Purchases.Count == 0)
                throw (new Exception("Список пуст."));
            else
            {
                var sortedPrice = Purchases.OrderByDescending(elem => elem.Price);
                foreach (Purchase elem in sortedPrice)
                {
                    purchases.Add(elem);
                }
                return purchases;
            }
        }
    }
}
