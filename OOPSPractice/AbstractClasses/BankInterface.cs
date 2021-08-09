using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public class BankInterface
    {
        public void ShowInterface()
        {
            Console.WriteLine("Choose your Bank: \n1. HDFC\n2.SBI");
        }

        public void ShowOptions()
        {
            Console.WriteLine("1.Calculate Interest\n2. Get Loan");
        }

        public void CalculateSI(Bank bank, double sum, int time)
        {
            Console.WriteLine(bank.CalculateSI(sum, time));
        }
        
        public void HandOutLoan(Bank bank)
        {
            Console.WriteLine("Your bank has given out a loan for: " + bank.HandOutLoan());
        }
    }
}
