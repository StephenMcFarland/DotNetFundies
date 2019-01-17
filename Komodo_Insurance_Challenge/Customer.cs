using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Insurance_Challenge
{
    public enum GenderType { Male, Female, Other }

    public class Customer
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public GenderType Gender { get; set; }
        public bool HadAccident { get; set; }

        //Here we are using List as a property of the Customer class
        //This allows us to tie all vehicles on this list to the specific instance of the class
        public List<Vehicle> VehicleList { get; set; }

        public Customer()
        {
            VehicleList = new List<Vehicle>();
        }

        public Customer(string name, int age, GenderType gender)
        {
            FullName = name;
            Age = age;
            Gender = gender;
            VehicleList = new List<Vehicle>();
        }
    }
}
