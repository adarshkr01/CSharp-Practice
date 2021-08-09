using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bank
    {
        public double Rate = 6.0;

        public virtual double CalculateSimpleInterest(double sum, double time)
        {
            return sum + (sum * Rate * time) / 100;
        }
    }
}
