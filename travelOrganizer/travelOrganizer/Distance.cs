using System.Collections.Generic;

namespace travelOrganizer

{
    public class Distance
    {
        public double KMeters { get; set; }
        public string Name { get; set; }
        public Distance() { Name = "Без имени"; KMeters = 0; }
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
}

