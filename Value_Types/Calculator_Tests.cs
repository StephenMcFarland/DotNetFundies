using System;
using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Value_Types
{
    [TestClass]
    public class Calculator_Tests
    {
        [TestMethod]
        public void Calculator_AddTwoNumbers_ShouldBeCorrectValue()
        {
            //Arrange
            CalculatorRepository calcRepo = new CalculatorRepository();

            //Act
            int actualValue = calcRepo.AddTwoNumbers(4,3);
            int expected = 7;
            //Assert
            Assert.AreEqual(expected, actualValue);
        }
        [TestMethod]
        public void Calculator_SubtractTwoNumbers_ShouldBeCorrectValue()
        {
            //Arrange
            CalculatorRepository calcRepo = new CalculatorRepository();

            //Act
            int actualValue = calcRepo.SubtractTwoNumbers(4,3);
            int expected = 1;
            //Assert
            Assert.AreEqual(expected, actualValue);
        }
        [TestMethod]
        public void Calculator_DivideTwoNumbers_ShouldBeCorrectValue()
        {
            //Arrange
            CalculatorRepository calcRepo = new CalculatorRepository();

            //Act
            int actualValue = calcRepo.DivideTwoNumbers(9,3);
            int expected = 3;
            //Assert
            Assert.AreEqual(expected, actualValue);
        }
        [TestMethod]
        public void Calculator_MultiplyTwoNumbers_ShouldBeCorrectValue()
        {
            //Arrange
            CalculatorRepository calcRepo = new CalculatorRepository();

            //Act
            int actualValue = calcRepo.MultiplyTwoNumbers(9,3);
            int expected = 27;
            //Assert
            Assert.AreEqual(expected, actualValue);
        }
    }
}
