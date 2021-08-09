using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace Asyncccc
{
    class Program
    {
        public static void Method1(int a)
        {
            for(int i = 0; i < 50; i++)
                Console.Write(++a + " ");
        }

        public static void Method2(int a)
        {
            for (int i = 0; i < 50; i++)
                Console.Write(++a + " ");
        }
        static void Main(string[] args)
        {
            int a = 7;

            Thread t1 = new Thread(() => Method1(a));
            Thread t2 = new Thread(() => Method2(a));


            t1.Start();
            t2.Start();
        }
    }
}
