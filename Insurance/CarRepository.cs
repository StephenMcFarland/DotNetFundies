using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance
{
    public class CarRepository
    {
        List<Car> _carList = new List<Car>();

        public void AddCarToList(Car transformer)
        {
            _carList.Add(transformer);
        }

        public List<Car> GetCarList()
        {
            return _carList;
        }

        public void RemoveCarFromList(Car car)
        {
            _carList.Remove(car);
        }

        public decimal InsuranceCost(Car transformer)
        {

            decimal insurance = 0m;

            if (transformer.Year >= 1960 && transformer.Year <= 1970)
            {
                insurance = 50m;
            }
            else if (transformer.Year >= 1971 && transformer.Year <= 1980)
            {
                insurance = 75m;

            }
            else if (transformer.Year >= 1981 && transformer.Year <= 1991)
            {
                insurance = 150m;
            }
            else
            {
                insurance = 2000m;
            }

            return insurance;
        }
    }
}
