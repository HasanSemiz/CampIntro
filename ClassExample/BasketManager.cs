using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExample
{
    class BasketManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Add to Basket." + product.ProductName);
        }
    }
}
