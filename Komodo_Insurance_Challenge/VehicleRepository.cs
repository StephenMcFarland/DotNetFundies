using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Insurance_Challenge
{
    public class VehicleRepository
    {
        private List<Vehicle> _vehicleList;

        //Constructor
        public VehicleRepository(List<Vehicle> list)
        {
            //This list is being passed in from outside, specifically coming from the Customer object we are working with in the UI
            _vehicleList = list;
        }

        public void AddVehicleToList(Vehicle newVehicle)
        {
            _vehicleList.Add(newVehicle);
        }

        public List<Vehicle> GetVehicleList()
        {
            return _vehicleList;
        }

        public decimal CalculateVehiclePremium(Vehicle vehicle)
        {
            decimal premium = 0;
            if (vehicle.Mileage >= 50000 && vehicle.Mileage < 100000)
            {
                premium = 25.00m;
            }
            else if (vehicle.Mileage >= 100000)
            {
                premium = 50.00m;
            }
            return premium;
        }
    }
}
