using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class HDFCBank : Bank
    {
        public new double Rate = 7.5;
        
        public override double CalculateSimpleInterest(double sum, double time)
        {
            return sum + (sum * Rate * time) / 100;
        }
    }
}
