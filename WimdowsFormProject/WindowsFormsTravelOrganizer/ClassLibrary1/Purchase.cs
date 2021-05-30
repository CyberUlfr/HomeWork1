using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        List<Purchase> Purchases = new List<Purchase>();
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
    }
    
}
