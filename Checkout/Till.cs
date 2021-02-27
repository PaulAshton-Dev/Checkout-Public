using System;

namespace Checkout
{
    public class Till
    {
        public bool TakePayment(IBasket basket, Customer customer, IPaymentProvider paymentProvider,
            out decimal paymentValue, out string reference)
        {
            // total the basket
            decimal total = 0;

            foreach (var product in basket.Items) total += product.Price;

            total = total - total / 100 * customer.Discount;

            reference = Guid.NewGuid().ToString();
            paymentValue = total;
            return paymentProvider.TakePayment(total);
        }
    }
}