using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.Collection
{
    internal class GenericStack
    {
        private static void PrintGenericStack()
        {
            Stack<string> stack = new Stack<string>();

            stack.Push("C#");
            stack.Push(".Net");
            stack.Push("MVC");

            Console.WriteLine(stack.Peek());

            Console.WriteLine("------");

            foreach (string s in stack)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("=====");

            stack.Pop();

            foreach (string s in stack)
            {
                Console.WriteLine(s);
            }
        }
        //static void Main(string[] args)
        //{
        //    PrintGenericStack();
        //}
    }
}
