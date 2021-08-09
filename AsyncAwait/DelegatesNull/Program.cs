using System;

namespace DelegatesNull
{
    class Program
    {
        static void Main(string[] args)
        {
            DelegateRunner delegateRunner = new DelegateRunner();
            delegateRunner.Runner(15, null);
        }
    }
}
