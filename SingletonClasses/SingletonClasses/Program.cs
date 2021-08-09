using System;

namespace SingletonClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonClass s1 = SingletonClass.Instance;
            s1.num1 = 15;
            s1.num2 = 20;
            SingletonClass s2 = SingletonClass.Instance;

            Console.WriteLine(s2.num2);
            s2.Sum();
        }
    }
}
