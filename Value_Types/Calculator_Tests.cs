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
    }
}
