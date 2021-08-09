using System;

namespace StructTypeExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            Console.WriteLine(a.IsGreaterThan10());
            a.Make10();
            Console.WriteLine(a);
        }
    }
}
