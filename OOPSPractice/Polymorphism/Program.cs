using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();

            Console.WriteLine(bank.CalculateSIAmount(time: 3, sum: 10000));
            Console.WriteLine(Math.Round(bank.CalculateSIAmount(12000.25), 2));
        }
    }
}
