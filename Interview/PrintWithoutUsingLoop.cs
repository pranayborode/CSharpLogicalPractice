using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.Interview
{
    internal class PrintWithoutUsingLoop
    {
        public static void PrintNext(int i)
        {
            if (i <= 100)
            {
                Console.WriteLine(i);
                PrintNext(i + 1);
            }
        }


        //static void Main(string[] args)
        //{
        //    PrintNext(1);
        //}
    }
}
