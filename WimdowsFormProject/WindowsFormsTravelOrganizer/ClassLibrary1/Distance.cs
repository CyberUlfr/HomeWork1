using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary1
{
    public class Distance
    {
        public double KMeters { get; set; }
        public string Name { get; set; }
        public Distance(string name, double kmeters)
        {
            Name = name;
            KMeters = kmeters;
        }
        public override string ToString()
        {
            return string.Format($"{Name} прошел {KMeters} км.");
        }
    }
    public class DistanceModel
    {
        public List<Distance> Distances = new List<Distance>();
        public void AddElem(string name, double kmeters)
        {
            if (Distances.Any(u => u.Name == name))
                throw (new Exception("Данный продукт уже добавлен!"));
            Distances.Add(new Distance(name, kmeters));
        }
    }
}
