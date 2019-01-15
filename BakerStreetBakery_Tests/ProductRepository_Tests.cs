using System;
using BakerStreetBakery;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BakerStreetBakery_Tests
{
    [TestClass]
    public class ProductRepository_Tests
    {
        [TestMethod]
        public void ProductRepository_CalculateCost_ShouldBeCorrectDecimal()
        {
            //Arrange
            ProductRepository _productRepo = new ProductRepository();
            BakeType product = BakeType.Pastery;

            //Act
            decimal actual = _productRepo.CalculateCost(product);
            decimal expected = 300.10m;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
