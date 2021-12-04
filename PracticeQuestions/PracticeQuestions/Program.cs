using System;
using System.Collections.Generic;

namespace PracticeQuestions
{
    public class Generic<T>
    {
        Stack<T> stk = new Stack<T>();
        public void push(T obj)
        {
            stk.Push(obj);
        }
        public T pop()
        {
            T obj = stk.Pop();
            return obj;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Generic<int> g = new Generic<int>();
            g.push(50);
            Console.WriteLine(g.pop());
            Console.ReadLine();
        }
    }
}