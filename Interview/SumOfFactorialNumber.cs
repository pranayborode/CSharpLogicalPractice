using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.Interview
{
    internal class SumOfFactorialNumber
    {
        public static void CalcFactorial(int num)
        {
            long sumOfFactorial = 0;

            for (int i = 1; i <= num; i++)
            {
                long factorial = 1;
                for (int j = 1; j <= i; j++)
                {
                    factorial *= j;
                }
                sumOfFactorial += factorial;
            }
            Console.WriteLine(sumOfFactorial);
        }

        //static void Main(string[] args)
        //{

        //    Console.Write("Enter the Number: ");
        //    int num = Convert.ToInt32(Console.ReadLine());

        //    CalcFactorial(num);

        //}
    }
}
