using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Product> hashset = new HashSet<Product>();

            Product pr = new Product() { Name = "Bike", Price = 400 };

            hashset.Add(pr);
            hashset.Add(new Product() { Name = "Soap", Price = 500 });
            hashset.Add(new Product() { Name = "Soap", Price = 500 });
            hashset.Add(new Product() { Name = "Soap", Price = 500 });
            hashset.Add(pr);

            Console.WriteLine(hashset.Count);
        }
    }
}
