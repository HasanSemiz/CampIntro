using System;

namespace ClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductId = 1;
            product1.ProductName = "Laptop";
            product1.ProductDetail = "ASUS TP500LB";

            Product product2 = new Product();
            product2.ProductId = 2;
            product2.ProductName = "Phone";
            product2.ProductDetail = "Iphone 7 Plus 32 GB";

            Product product3 = new Product();
            product3.ProductId = 3;
            product3.ProductName = "Wallet";
            product3.ProductDetail = "Calvin Clean Wallet";

            Product[] products = new Product[] { product1, product2, product3 };

            Console.WriteLine("With Foreach:");
            foreach (var product in products)
            {
                Console.WriteLine(product.ProductId + " " + product.ProductName + " " + product.ProductDetail);
            }

            Console.WriteLine("With For:");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].ProductId + " " + products[i].ProductName + " " + products[i].ProductDetail);
            }

            Console.WriteLine("With While:");
            int a = 0;
            while (a < products.Length)
            {
                Console.WriteLine(products[a].ProductId + " " + products[a].ProductName + " " + products[a].ProductDetail);
                a++;
            }

            Console.WriteLine("*********************************");

            BasketManager basketManager = new BasketManager();
            basketManager.Add(product1);
        }
    }
}
