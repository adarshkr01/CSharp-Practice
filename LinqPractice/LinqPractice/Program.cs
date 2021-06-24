using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Book> books = new BookRepository().GetBooks();

            //// Linq Query Operators
            //var cheaperBooks =
            //                    from b in books
            //                    where b.Price < 15
            //                    orderby b.Title
            //                    select b;

            // Linq Extension Methods
            var cheapBooks = books
                                .Where(b => b.Price < 15)
                                .OrderBy(b => b.Title);

            foreach(Book book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }

            var cheapBooksTitle = cheapBooks.Select(b => b.Title);


            // ********************

            Book book1 = books.Single(b => b.Title == "Hamlet"); 
            // returns an object. Gives exception if no match
            Console.WriteLine(book1.Title);

            Book book2 = books.SingleOrDefault(b => b.Title == "Origin");
            Console.WriteLine(book2 == null); // True because "Origin" is not in the list

            
        }
    }
}
