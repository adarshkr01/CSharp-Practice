using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class CallWebServiceProvider : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Called a web serive provider");
        }
    }
}
