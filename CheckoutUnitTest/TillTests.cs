using Checkout;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CheckoutUnitTest
{
    [TestClass]
    public class TillTests
    {
        [TestInitialize]
        public void TestInitialise()
        {
        }

        [TestCleanup]
        public void TestCleanUp()
        {
        }


        [TestMethod]
        public void Test001_PaymentProvider_Take_Payment_Successfully()
        {
            // arrange
            IPaymentProvider paymentProvider = new PaymentProvider();

            // act
            var successfulPayment = paymentProvider.TakePayment(100.00m);

            // assert
            Assert.IsTrue(successfulPayment);
        }

        [TestMethod]
        public void Test002_Till_Take_Payment_Successfully()
        {
            // arrange
            IBasket basket = new Basket();
            IPaymentProvider paymentProvider = new PaymentProvider();
            var customer = new Customer("John Smith");

            var product = new Product("Apples", 1.00m);

            basket.Add(product);

            // act
            var successfulPayment = new Till().TakePayment(basket, customer, paymentProvider, out _, out _);

            // assert
            Assert.IsTrue(successfulPayment);
        }

        [TestMethod]
        public void Test003_Till_Take_Payment_With_Customer_Discount_Successfully()
        {
            // arrange
            IBasket basket = new Basket();
            IPaymentProvider paymentProvider = new PaymentProvider();
            var customer = new Customer("John Smith", 10.00m);

            var product = new Product("Apples", 1.00m);

            basket.Add(product);

            // act
            var successfulPayment = new Till().TakePayment(basket, customer, paymentProvider, out var paymentValue, out var paymentReference);

            // assert
            Assert.IsTrue(successfulPayment);
            Assert.AreEqual(00.9m, paymentValue);
            Assert.IsFalse(string.IsNullOrEmpty(paymentReference));
        }
    }
}