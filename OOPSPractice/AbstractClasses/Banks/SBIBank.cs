using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses.Banks
{
    public class SBIBank : Bank
    {
        private double _rate = 6;
        public override double CalculateSI(double sum, int time)
        {
            return 1500 + sum + (sum * _rate * time) / 100;
        }

        public override double HandOutLoan()
        {
            return 20000;
        }
    }
}
