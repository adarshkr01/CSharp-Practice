using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class Program
    {
        public static void Main(string[] args)
        {
            Method2();
            Method4();
        }

        async static Task Method2()
        {
            await Method3();
            Console.WriteLine("We are here");
        }

        async static Task Method3()
        {
            for(int i = 0; i < 40; i++)
            {
                Console.WriteLine("ABC");
            }
        }

        async static Task Method4()
        {
            for(int i = 0; i < 50; i++)
            {
                Console.WriteLine("123");
            }
        }
    }
}
