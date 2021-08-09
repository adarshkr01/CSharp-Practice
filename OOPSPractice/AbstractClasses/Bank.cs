using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public abstract class Bank
    {
        public abstract double CalculateSI(double sum, int time);
        public abstract double HandOutLoan();
    }
}
