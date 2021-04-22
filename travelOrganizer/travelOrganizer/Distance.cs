namespace travelOrganizer
{
    class Distance
    {
        public double KMeters { get; set; }
        public string Name { get; set; }
        public Distance(string name, double kmeters)
        {
            Name = name;
            KMeters = kmeters;
        }
    }
}

