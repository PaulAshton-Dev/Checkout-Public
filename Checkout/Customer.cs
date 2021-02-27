using System;

namespace Checkout
{
    public class Customer
    {
        public Customer(string name, decimal discount)
        {
            if (discount < 0)
                throw new ArgumentOutOfRangeException(nameof(discount), discount, "Negative discount not allowed");

            Name = name;
            Discount = discount;
        }

        public Customer(string name)
        {
            Name = name;
            Discount = 0;
        }

        public string Name { get; }
        public decimal Discount { get; }
    }
}