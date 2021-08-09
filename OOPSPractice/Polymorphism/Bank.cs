using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Bank
    {
        private double _rate = 6.0;

        public virtual double CalculateSIAmount(double sum)
        {
            return sum + (sum * _rate) / 100;
        }

        public virtual double CalculateSIAmount(double sum, double time)
        {
            return sum + (sum * _rate * time) / 100;
        }
    }
}
