using System;

namespace ClassesPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpCookie cookie = new HttpCookie();
            cookie["name"] = "Adarsh";
            cookie["token"] = "55sdf57asdf46a46af7";
            
            Console.WriteLine(cookie["token"]);

            //Object Initializer
            Customer customer = new Customer 
                                {
                                   Id = 1,
                                   Name = "Hello"
                                };

            Console.WriteLine(customer.Name);

            Console.WriteLine(Add(1, 2));
            Console.WriteLine(Add(2, 4, 5, 7, 2));

            Person person = new Person();
            person.Birthdate = new DateTime(2000, 02, 01);
            Console.WriteLine(person.Birthdate);
        }

        public static int Add(params int[] numbers)
        {
            int sum = 0;

            foreach(int num in numbers)
            {
                sum += num;
            }

            return sum;
        }
    }
}
