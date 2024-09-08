using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.Collection
{
    internal class GenericQueue
    {
        private static void PrintGenericQueue()
        {

            Queue<string> queue = new Queue<string>();

            queue.Enqueue("C#");
            queue.Enqueue(".Net");
            queue.Enqueue("MVC");

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("================");
            queue.Dequeue();

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

        }
        //static void Main(string[] args)
        //{
        //    PrintGenericQueue();
        //}
    }

}
