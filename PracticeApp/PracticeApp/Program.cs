using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeApp
{
    public enum Fruits
    {
        Apple,
        Mango
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> Books = new List<Book>
            {
                new Book() { Name = "Merchant of Venice", Price = 150, AuthorId = 1 },
                new Book() { Name = "Origin", Price = 300, AuthorId = 2 },
                new Book() { Name = "As You Like It", Price = 100, AuthorId = 1 },
                new Book() { Name = "The Tempest", Price = 150, AuthorId = 1 },
            };

            bool val = Books.All(b => b.Price >= 150);
            Console.WriteLine(val);

            Console.WriteLine(Books.ElementAtOrDefault(2));
            Console.WriteLine(Enum.GetUnderlyingType(typeof(Fruits)));
            IQueryable
        }
    }
}
