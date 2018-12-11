using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    public class River
    {
        public string Name { get; set; }
        public double Lenght { get; set; }
        public string Country { get; set; }
        public double Depth { get; set; }
        public double Bridge { get; set; }
        public double Height { get; set; }
        public bool HasBridge { get; set; }

        public River()
        {
        }
        public River(string name, double lenght, string country,
        double depth, double bridge, double height, bool hasBridge)
        {
            Name = name;
            Lenght = lenght;
            Country = country;
            Depth = depth;
            Height = height;
            Bridge = bridge;
            HasBridge = hasBridge;
        }
    }
}
