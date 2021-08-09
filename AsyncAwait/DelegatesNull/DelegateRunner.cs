using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesNull
{
    public class DelegateRunner
    {
        public void Runner(int num, Action<int> action)
        {
            action(num);
        }
    }
}
