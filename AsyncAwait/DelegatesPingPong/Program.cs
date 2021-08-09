using System;

namespace DelegatesPingPong
{
    class Program
    {
        static void Main(string[] args)
        {
            RunnerClass runnerClass = new RunnerClass();
            //Action<int> emptyDelegate = new Action<int>(returnSq);
            Action<int> emptyDelegate = null;
            runnerClass.Run(emptyDelegate);
        }

        public static void returnSq(int a)
        {
            Console.WriteLine(a * a);
        }
    }
}
