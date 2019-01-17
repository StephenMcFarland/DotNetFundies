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

        [TestMethod]
        public void ProductRepository_AddProductOrderToList_ShouldBeCorrectCount()
        {
            //Arrange
            ProductRepository _productRepo = new ProductRepository();
            Product product = new Product();
            Product productTwo = new Product();
            Product productThree = new Product();

            _productRepo.AddProductOrderToList(product);
            _productRepo.AddProductOrderToList(productTwo);
            _productRepo.AddProductOrderToList(productThree);
            //Act
            int actual = _productRepo.GetOrderedProducts().Count;
            int expected = 3;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProductRepository_RemoveOrderedProduct_ShouldBeCorrectCount()
        {
            //Arrange
            ProductRepository _productRepo = new ProductRepository();
            Product product = new Product();
            Product productTwo = new Product();
            Product productThree = new Product();

            _productRepo.AddProductOrderToList(product);
            _productRepo.AddProductOrderToList(productTwo);
            _productRepo.AddProductOrderToList(productThree);

            _productRepo.RemoveOrderedProduct(product);
            //Act
            int actual = _productRepo.GetOrderedProducts().Count;
            int expected = 2;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProductRepository_RemoveOrderedProductBySpecification_BoolShouldReturnTrue()
        {
            //Arrange
            ProductRepository _productRepo = new ProductRepository();
            Product product = new Product("bread", BakeType.Bread, 45, "Larry", 300m);
            Product productTwo = new Product("bread", BakeType.Cake, 45, "Larry", 300m);
            Product productThree = new Product("bread", BakeType.Bread, 45, "Larry", 300m);

            _productRepo.AddProductOrderToList(product);
            _productRepo.AddProductOrderToList(productTwo);
            _productRepo.AddProductOrderToList(productThree);
            
            //Act
            bool actual = _productRepo.RemoveProductBySpecifications(productTwo.CustomerName, productTwo.ProductName, productTwo.BakeType);
            bool expected = true;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
