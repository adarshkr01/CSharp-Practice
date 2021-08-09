using System;
using System.Collections.Generic;
using System.Text;

namespace LinqPractice
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() { Title = "Merchant of Venice", Price = 15.2f },
                new Book() { Title = "As You Like It", Price = 17.99f },
                new Book() { Title = "Much Ado About Nothing", Price = 14.99f },
                new Book() { Title = "Two Gentlemen of Verona", Price = 12 },
                new Book() { Title = "Hamlet", Price = 5 },
            };
        }
    }
}
