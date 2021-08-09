using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            HDFCBank bank = new HDFCBank();
            double amount = bank.CalculateSimpleInterest(10000, 3);
            Console.WriteLine(amount);

            SBIBank sbibank = new SBIBank();
            amount = sbibank.CalculateSimpleInterest(10000, 3);
            Console.WriteLine(amount);
        }
    }
}
