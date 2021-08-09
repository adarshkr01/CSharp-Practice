using System;

namespace InterfacePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            ImplementInt implementInt = new ImplementInt();
            implementInt.num1 = 55;
            implementInt.checkIfGreaterThan20();
        }
    }
}
