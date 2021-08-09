using System;

namespace PrivateMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c1 = new Class1();
            c1.val1 = 10;
            Console.WriteLine(c1.val1);
            c1.val1 = 20;
            Console.WriteLine(c1.val1);

            Class2 c2 = new Class2(10);
        }
    }
}
