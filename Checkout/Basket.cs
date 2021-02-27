using System.Collections.Generic;

namespace Checkout
{
    public interface IBasket
    {
        List<Product> Items { get; }
        void Add(Product product);
    }

    public class Basket : IBasket
    {
        public Basket()
        {
            Items = new List<Product>();
        }

        public List<Product> Items { get; }

        public void Add(Product product)
        {
            Items.Add(product);
        }
    }
}