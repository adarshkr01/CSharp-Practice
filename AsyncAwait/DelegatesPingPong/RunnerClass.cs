using System;

namespace DelegatesPingPong
{
    public class RunnerClass
    {
        public void Run(Action<int> methodRun)
        {
            methodRun(7);
        }
    }
}
