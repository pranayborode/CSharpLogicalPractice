using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.Interview
{
    internal class PrimeNumbers
    {
        public static bool CheckPrime(int num)
        {

            if (num == 0 || num == 1)
            {
                return false;
            }
            else
            {
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        //static void Main(string[] args)
        //{
        //    for (int i = 0; i <= 50; i++)
        //    {
        //        if (CheckPrime(i))
        //        {
        //            Console.WriteLine(i);
        //        }
        //    }

        //}

    }
}
