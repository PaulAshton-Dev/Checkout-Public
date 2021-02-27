using System;

namespace Checkout
{
    public interface IPaymentProvider
    {
        bool TakePayment(decimal bill);
    }

    public class PaymentProvider : IPaymentProvider
    {
        public bool TakePayment(decimal bill)
        {
            if (bill <= 0) throw new ArgumentOutOfRangeException("bill value is invalid");

            return true;
        }
    }
}