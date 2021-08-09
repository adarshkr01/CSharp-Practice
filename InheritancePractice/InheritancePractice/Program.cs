using System;

namespace InheritancePractice
{
    public class Base
    {
        public int x;

        public void BaseMethod()
        {
            Console.WriteLine("Base Method");
        }
    }

    public class Derived : Base
    {
        public int y;

        public void DerivedMethod()
        {
            Console.WriteLine("Derived Method");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Derived d = new Derived();
            d.y = 50;
            d.DerivedMethod();

            Base b = d;
            Console.WriteLine(b.y);
            b.DerivedMethod();
        }
    }
}
