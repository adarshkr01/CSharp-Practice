using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    public class Person
    {
        public string firstName;
        public string lastName;

        public void Introduce()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }
}
