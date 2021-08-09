using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses.Banks
{
    public class HDFCBank : Bank
    {
        private double _rate = 7;
        public override double CalculateSI(double sum, int time)
        {
            return sum + (sum * _rate * time) / 100;
        }

        public override double HandOutLoan()
        {
            return 15000;
        }
    }
}
