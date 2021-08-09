using System;
using System.Collections;
using System.Text;

namespace Inheritance
{
    class Stack
    {
        private ArrayList _stack = new ArrayList();

        public void Push(Object val)
        {
            if(val == null)
            {
                throw new InvalidOperationException();
            }

            _stack.Add(val);
        }

        public Object Pop()
        {
            if(_stack.Count == 0)
            {
                throw new InvalidOperationException();
            }

            Object o = _stack[_stack.Count - 1];
            _stack.RemoveAt(_stack.Count - 1);
            return o;
        }

        public void Clear()
        {
            _stack.Clear();
        }
    }
}
