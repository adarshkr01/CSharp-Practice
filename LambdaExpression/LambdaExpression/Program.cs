using System;
using System.Collections.Generic;

namespace LambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 5;

            Console.WriteLine(Square(num));

            Func<int, int> sq = Square;
            // sq is Delegate (run sq to see the result)
            // First int is the parameter type, second is the return type.
            // Func<int, int, int> means first two parameter is parameter, and third is return type

            Console.WriteLine(sq(num));



            // Using Lambda Expression

            // args => expression
            // () => ...         (No parameter)
            // x => ...          (1 parameter)
            // (x, y, z) => ...  (Multi-parameter)
            // num => num * num;

            Func<float> getPI = () => 3.14f;
            // no parameter
            Console.WriteLine(getPI());


            Func<int, int> lambdaSq = num => num * num;
            // 1 parameter
            Console.WriteLine(lambdaSq(num));


            Func<int, int, int> largest = (a, b) => a > b ? a : b;
            // Multiple paramater
            Console.WriteLine(largest(4, 5));




            // using predicate method to return books whose price are less than 10
            List<Book> bookLibrary = new BookLibrary().GetBooks();

            List<Book> cheapBooks = bookLibrary.FindAll(IsCheaperThan10);

            foreach(Book book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }

            // same as above using Lambda expression
            List<Book> cheapBooks2 = bookLibrary.FindAll(book => book.Price < 10);

            foreach (Book book in cheapBooks2)
            {
                Console.WriteLine(book.Title);
            }
        }

        public static int Square(int num)
        {
            return num * num;
        }

        static bool IsCheaperThan10(Book book)
        { // Predicate method
            return book.Price < 10;
        }
    }
}
