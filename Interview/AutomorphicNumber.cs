using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.Interview
{
    internal class AutomorphicNumber
    {
        public static bool checkAutomorphic(int num)
        {

            long sq = num * num;

            while (num > 0)
            {
                if (num % 10 != sq % 10)
                {
                    return false;
                }
                num /= 10;
                sq /= 10;
            }
            return true;

        }

        //static void Main(string[] args)
        //{

        //    Console.Write("Enter the Number: ");
        //    int num = Convert.ToInt32(Console.ReadLine());

        //    if (checkAutomorphic(num))
        //    {
        //        Console.WriteLine("Automorphic");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Not Automorphic");
        //    }

        //}
    }
}
