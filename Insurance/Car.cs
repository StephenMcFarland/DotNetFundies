using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public int WheelCount { get; set; }
        public bool PreviousAccident { get; set; }
        public int PreviousOwners { get; set; }

        public Car(string brand, string model, int year, string type, string color, int wheels, bool previousAccident, int previousOwners)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Type = type;
            Color = color;
            WheelCount = wheels;
            PreviousAccident = previousAccident;
            PreviousOwners = previousOwners;
        }

        public Car()
        {

        }
    }
}
