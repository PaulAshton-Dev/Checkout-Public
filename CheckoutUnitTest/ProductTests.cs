using System;
using Checkout;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CheckoutUnitTest
{
    [TestClass]
    public class ProductTests
    {
        [TestMethod]
        public void Test001_Product_Creation()
        {
            // arrange
            var product = new Product("Apples", 1.00m);

            // act

            // assert
            Assert.AreEqual("Apples", product.Name);
            Assert.AreEqual(1.00m, product.Price);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test002_Product_Creation_Invalid_Price()
        {
            // arrange
            var product = new Product("Apples", 0);
        }
    }
}