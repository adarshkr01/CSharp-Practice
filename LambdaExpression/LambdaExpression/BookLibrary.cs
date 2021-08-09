using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaExpression
{
    public class BookLibrary
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() { Title = "Merchant of Venice", Price = 8 },
                new Book() { Title = "As You Like It", Price = 6 },
                new Book() { Title = "Tempest", Price = 17 }
            };
        }
    }
}
