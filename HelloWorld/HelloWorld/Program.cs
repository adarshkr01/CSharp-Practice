using System;
using System.Text;

namespace HelloWorld
{
    class Program 
    {
        public enum colours
        {
            Red,
            Blue,
            Green = 7,
            Purple = 0,
            Pink
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(colours.Red);
            Console.WriteLine(colours.Purple);
            Console.WriteLine(colours.Green);
            Console.WriteLine(colours.Pink);

            Console.WriteLine();

            Console.WriteLine((int) colours.Red);
            Console.WriteLine((int) colours.Purple); 
            Console.WriteLine((int) colours.Green);
            Console.WriteLine((int) colours.Pink);


            /*
            string s1 = new string("Hello");
            string s2 = new string("Hello");
            string s3 = "Hello";

            Console.WriteLine(s1 == s2);
            Console.WriteLine(s1.Equals(s2));
            Console.WriteLine(string.Equals(s1, s2));

            Console.WriteLine();
            
            Console.WriteLine(s1 == s3);
            Console.WriteLine(s1.Equals(s3));
            Console.WriteLine(string.Equals(s1, s3));

            String s4 = "A";
            string s5 = "B";

            Console.WriteLine(s4.CompareTo(s5));

            int a = 5;
            int b = a;

            a = 8;
            Console.WriteLine("\f");
            Console.WriteLine(s1.GetHashCode() + " " + s2.GetHashCode() + " " + s3.GetHashCode());
            Console.WriteLine("This or that is the answer");
            */

        }
    }
}
