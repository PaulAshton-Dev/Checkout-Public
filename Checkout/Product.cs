using System;

namespace Checkout
{
    public class Product
    {
        public Product(string name, decimal price)
        {
            if (price <= 0) throw new ArgumentOutOfRangeException(nameof(price), price, "Negative price not allowed");

            Name = name;
            Price = price;
        }

        public string Name { get; }
        public decimal Price { get; }
    }
}