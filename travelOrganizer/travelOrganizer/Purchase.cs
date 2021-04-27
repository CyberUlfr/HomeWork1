using System;
using System.Collections.Generic;

namespace travelOrganizer
{
    public class Purchase
    {
        public static List<Purchase> Purchases { get; set; } = new List<Purchase>();
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
            return string.Format($"{Name} стоит {Price} руб.");
        }
    }
}