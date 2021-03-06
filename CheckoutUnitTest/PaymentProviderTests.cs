﻿using System;
using Checkout;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CheckoutUnitTest
{
    [TestClass]
    public class PaymentProviderTests
    {
        [TestMethod]
        public void Test001_Payment_Successful()
        {
            // arrange
            var paymentProvider = new PaymentProvider();

            // act
            var success = paymentProvider.TakePayment(200);

            // assert
            Assert.IsTrue(success);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test002_Payment_Creation_Invalid_Zero_Price()
        {
            // arrange
            var paymentProvider = new PaymentProvider();

            // act
            var success = paymentProvider.TakePayment(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test003_Payment_Creation_Invalid_Negative_Price()
        {
            // arrange
            var paymentProvider = new PaymentProvider();

            // act
            var success = paymentProvider.TakePayment(-.01m);
        }
    }
}