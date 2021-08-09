using System.Collections;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push("Hello");
            stack.Push('c');

            System.Console.WriteLine(stack.Pop());
            System.Console.WriteLine(stack.Pop());
            System.Console.WriteLine(stack.Pop());
            System.Console.WriteLine(stack.Pop());
        }
    }
}
