using System;
using Insurance;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Value_Types
{
    [TestClass]
    public class Insurance_Tests
    {
        [TestMethod]
        public void InsuranceCar_Properties_ShouldBeCorrectValues()
        {
            //This shows you can have multiple objects of the same type. In this method I have two cars.This also shows that properties can have the same value for multiple objects.
            Car truck = new Car();
            truck.Brand = "Autobots";
            truck.Model = "Camaro";
            truck.Year = 1984;
            truck.Type = "Car";
            truck.Color = "Yellow";
            truck.WheelCount = 4;
            truck.PreviousAccident = true;
            truck.PreviousOwners = 0;

            Car car = new Car();
            car.Brand = "Autobots";
            car.Model = "Camaro";
            car.Year = 1984;
            car.Type = "Car";
            car.Color = "Yellow";
            car.WheelCount = 4;
            car.PreviousAccident = true;
            car.PreviousOwners = 0;


            //I am only showing two assert statements one for each object. 
            string actualTruck = truck.Brand;
            string expectedTruck = "Autobots";

            string actualCar = car.Brand;
            string expectedCar = "Autobots";


            Assert.AreEqual(expectedTruck, actualTruck);
            Assert.AreEqual(expectedCar, actualCar);
        }

        [TestMethod]
        public void InsuranceCar_Constructor_ShouldBeCorrectValues()
        {
            Car optimusPrime = new Car("Autobots", "PeterBilt 379", 1992, "Semi-Truck", "Blue with red flames", 10, false, 0);

            int actual = optimusPrime.WheelCount;
            int expected = 10;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsuranceCarRepository_InsuranceCost_DecimalShouldReturnCorrectValueBasedOnYear()
        {
            CarRepository _carRepo = new CarRepository();
            Car optimusPrime = new Car("Autobots", "PeterBilt 379", 1992, "Semi-Truck", "Blue with red flames", 10, false, 0);

            decimal actual = _carRepo.InsuranceCost(optimusPrime);
            decimal expected = 2000;

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void InsuranceCarRepository_AddToList_ShouldReturnCorrectCount()
        {
            //Arrange
            CarRepository _carRepo = new CarRepository();

            Car bumbleBee = new Car();
            bumbleBee.Brand = "Autobots";
            bumbleBee.Model = "Camaro";
            bumbleBee.Year = 1984;
            bumbleBee.Type = "Car";
            bumbleBee.Color = "Yellow";
            bumbleBee.WheelCount = 4;
            bumbleBee.PreviousAccident = true;
            bumbleBee.PreviousOwners = 0;

            //Act
            _carRepo.AddCarToList(bumbleBee);
            int actual = _carRepo.GetCarList().Count;
            int expected = 1;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsuranceCarRepository_RemoveFromList_ShouldReturnCorrectCount()
        {
            //Arrange
            CarRepository _carRepo = new CarRepository();
            Car bumbleBee = new Car("AutoBot", "Camaro", 1799, "muscle car", "Yellow with black racing stripes", 4, true, 0);
            //Even though the values aren't related to a car object they still satisfy the property types. I am showing non associated values to a car below to show that value can still be assigned even if it isn't what a car is in our mind.
            Car truck = new Car("This is a string type", "another string", 199, "right before this was a int value type. This is a string", "Another string", 400, false, 1998);

            //Act
            _carRepo.AddCarToList(bumbleBee);
            _carRepo.AddCarToList(truck);

            _carRepo.RemoveCarFromList(bumbleBee);

            int actual = _carRepo.GetCarList().Count;
            int expected = 1;
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
