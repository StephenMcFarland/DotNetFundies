using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Insurance_Challenge
{
    public class ProgramUI
    {
        private Customer _customer;
        private VehicleRepository _vehicleRepo;

        public ProgramUI()
        {
            _customer = new Customer();
            _vehicleRepo = new VehicleRepository(_customer.VehicleList);
        }

        public void Run()
        {
            Register();

            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine($"Hello {_customer.FullName}\n" +
                    "What would you like to do?\n" +
                    "1. View Information\n" +
                    "2. Update Information\n" +
                    "3. Register a Vehicle\n" +
                    "4. Exit application");

                string inputAsString = Console.ReadLine();
                int input = int.Parse(inputAsString);

                switch (input)
                {
                    case 1:
                        ViewInformation();
                        break;
                    case 2:
                        Register();
                        break;
                    case 3:
                        RegisterVehicle();
                        break;
                    case 4:
                        running = false;
                        break;
                }
            }
        }

        private void RegisterVehicle()
        {
            //make, model, year, and mileage
            Console.WriteLine("Enter the vehicle make:");
            string make = Console.ReadLine();

            Console.WriteLine("Enter the vehicle model:");
            string model = Console.ReadLine();

            Console.WriteLine("Enter the vehicle year:");
            string yearAsString = Console.ReadLine();
            int year = int.Parse(yearAsString);

            Console.WriteLine("Enter the vehicle mileage:");
            string mileageAsString = Console.ReadLine();
            int mileage = int.Parse(mileageAsString);

            Vehicle newVehicle = new Vehicle(make, model, year, mileage);
            _vehicleRepo.AddVehicleToList(newVehicle);
        }

        private void ViewInformation()
        {
            List<Vehicle> list = _vehicleRepo.GetVehicleList();

            decimal total = 0;

            //foreach (variableType variableName in collectionName)
            foreach (Vehicle vehicle in list)
            {
                decimal premium = _vehicleRepo.CalculateVehiclePremium(vehicle);
                total = total + premium; // total += premium;

                Console.WriteLine($"{vehicle.Year} {vehicle.Make} {vehicle.Model} - ${premium}");
            }

            if (_customer.Age >= 25)
            {
                total += 75;
            }
            else
            {
                total += 125;
            }

            if (_customer.HadAccident)
            {
                total += 25;
            }

            Console.WriteLine($"Your total cost is ${total}.");
            Console.ReadKey();
        }

        private void Register()
        {
            Console.WriteLine("Enter your full name:");
            _customer.FullName = Console.ReadLine();

            Console.WriteLine("Enter your age:");
            string ageAsString = Console.ReadLine();
            _customer.Age = int.Parse(ageAsString);

            Console.WriteLine("Enter your gender: \n1. Male\n2. Female\n3. Other");
            string genderAsString = Console.ReadLine().ToLower();
            switch (genderAsString)
            {
                case "male":
                case "1":
                    _customer.Gender = GenderType.Male;
                    break;
                case "female":
                case "2":
                    _customer.Gender = GenderType.Female;
                    break;
                case "other":
                case "3":
                default:
                    _customer.Gender = GenderType.Other;
                    break;
            }

            Console.WriteLine("Have you had an accident in the last 2 years? (Y/N)");
            string accidentResponseAsString = Console.ReadLine().ToLower();
            switch (accidentResponseAsString)
            {
                case "yes":
                case "y":
                    _customer.HadAccident = true;
                    break;
                case "no":
                case "n":
                default:
                    _customer.HadAccident = false;
                    break;
            }
        }
    }

}
