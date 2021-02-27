using System;
using Checkout;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CheckoutUnitTest
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void Test001_Customer_Creation()
        {
            // arrange
            var customer = new Customer("John Smith", 1.00m);

            // act

            // assert
            Assert.AreEqual("John Smith", customer.Name);
            Assert.AreEqual(1.00m, customer.Discount);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "")]
        public void Test002_Customer_With_Invalid_Discount()
        {
            // arrange
            var customer = new Customer("John Smith", -1);
        }
    }
}