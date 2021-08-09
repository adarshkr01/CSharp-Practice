using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice
{
    public interface Interface
    {
        public int num1 { get; set; }

        void checkIfGreaterThan10()
        {
            if(num1 > 10)
                Console.WriteLine("Number is greater than 10");
            else
                Console.WriteLine("Number is smaller than or equal to 10");
        }

        void checkIfGreaterThan20();
    }
}
