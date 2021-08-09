using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait2
{
    class Program
    {
        static void Main(string[] args)
        {
            RunnerAsync();
        }

        static void RunnerAsync()
        {
            Task t1 = Method1();
            Task t2 = Method2();
            Task t3 = Method3();

            Task.WaitAll(t1, t2, t3); // Waits for all of the tasks to finish
            // Task.WaitAny(t1, t2, t3); // Waits for any one of the tasks to finish
        }

        async static Task<int> Method1()
        {
            await Task.Delay(5000);
            Console.WriteLine("Method1");
            return 5;
        }

        async static Task<int> Method2()
        {
            await Task.Delay(3000);
            Console.WriteLine("Method2");
            return 7;
        }

        async static Task<int> Method3()
        {
            await Task.Delay(4000);
            Console.WriteLine("Method3");
            return 9;
        }
    }
}
