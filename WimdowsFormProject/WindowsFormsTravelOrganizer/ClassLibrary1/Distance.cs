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
            return string.Format($"{Name} пройденное растояние {KMeters} км.");
        }
    }
    public class DistanceModel
    {
        public List<Distance> Distances = new List<Distance>();

        public DistanceModel(List<Distance> distances)
        {
            Distances = distances;
        }

        public void AddDistance(string distance, double kmeters)
        {
            if (Distances.Any(u => u.Name == distance))
                throw (new Exception("Данное передвижение уже добавлено!"));
            Distances.Add(new Distance(distance, kmeters));
        }
        public void RemoveDistance(Distance distance)
        {
            Distances.Remove(distance);
        }
        public double DistanceStatistic()
        {
            double sum = Distances.Sum(elem => elem.KMeters);
            return sum;
        }
    }
}
