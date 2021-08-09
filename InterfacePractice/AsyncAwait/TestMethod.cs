using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait
{
    public class TestMethod
    {
        public async Task Runner()
        {
            int a = await Method1();
            a = await Method2();
            Method3();
        }
        public Task<int> Method1()
        {
            Console.WriteLine("Method 1");
            Thread.Sleep(5000);
            Console.WriteLine("Last Line of Method 1");
            
        }

        public Task<int> Method2()
        {
            Console.WriteLine("Method 2");
            Thread.Sleep(5000);
            Console.WriteLine("Last Line of Method 2");
            return 7;
        }

        public void Method3()
        {
            Console.WriteLine("Method 3");
        }
    }
}
