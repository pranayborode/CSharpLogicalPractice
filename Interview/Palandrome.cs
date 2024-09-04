using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.Interview
{
    internal class Palandrome
    {
        public static bool CheckPalandrome(int num)
        {
            int originalNum = num;
            int reverseNum = 0;

            do
            {
                int rem = num % 10;
                reverseNum = (reverseNum * 10) + rem;

                num /= 10;
            } while (num != 0);

            if (originalNum == reverseNum)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //static void Main(string[] args)
        //{
        //    int num = Convert.ToInt32(Console.ReadLine());

        //    if (CheckPalandrome(num))
        //    {
        //        Console.WriteLine($"Given number {num} is Palandrome NUmber");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"Given number {num} is Not Palandrome NUmber");
        //    }
        //}
    }
}
