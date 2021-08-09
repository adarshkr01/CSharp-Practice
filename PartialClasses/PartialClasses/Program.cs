using System;

namespace PartialClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            PartialClass partialClass = new PartialClass();
            partialClass.num1 = 5;
            partialClass.num2 = 15;
            partialClass.Sum();
            partialClass.Multiple();
        }
    }
}
