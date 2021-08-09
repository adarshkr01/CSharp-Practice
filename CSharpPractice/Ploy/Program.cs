using System;

namespace Ploy
{
    public class Parent
    {
        public int a = 7;
        public virtual void PrintMessage()
        {
            Console.WriteLine("Parent Class");
        }
    }

    public class Derived : Parent
    {
        public int a;
        public override void PrintMessage()
        {
            Console.WriteLine("Derived Class");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Parent d = new Derived();
            d.a = 5;
            Console.WriteLine(d.a);
            
            Type t = typeof(Derived);
            foreach(var x in t.GetFields())
            {
                Console.WriteLine(x.Name);
            }

            dynamic c = "Hi";
            Console.WriteLine(c.GetType());
            c = 5;
            Console.WriteLine(c.GetType());
            c = 'a';
            Console.WriteLine(c.GetType());
        }
    }
}
