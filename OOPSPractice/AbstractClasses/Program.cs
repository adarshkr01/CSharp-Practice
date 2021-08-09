using System;
using AbstractClasses.Banks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            BankInterface bankInterface = new BankInterface();
            bankInterface.ShowInterface();
            Bank bank = null;

            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    bank = new HDFCBank();
                    break;
                case 2:
                    bank = new SBIBank();
                    break;
                default:
                    break;
            }

            if (bank == null)
                Environment.Exit(0);

            bankInterface.ShowOptions();
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    bankInterface.CalculateSI(bank, 10000, 5);
                    break;
                case 2:
                    bankInterface.HandOutLoan(bank);
                    break;
                default:
                    break;
            }
        }
    }
}
