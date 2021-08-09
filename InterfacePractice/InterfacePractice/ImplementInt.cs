using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice
{
    class ImplementInt : Interface
    {
        public int num1 { get; set; }
        public void checkIfGreaterThan20()
        {
            if(num1 > 20)
                Console.WriteLine("Greater than 20!");
            else
                Console.WriteLine("Not greater than 20");
        }
    }
}
