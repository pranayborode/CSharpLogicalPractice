using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.Interview
{
    //Write a program to find frequency of each digit in a given integer.
    internal class FrequencyOfDigits
    {
        public static void FindFrequencyOfDigit(int num)
        {

            int i, count, digit, temp;

            for (i = 0; i <= 9; i++)
            {
                count = 0;
                temp = num;

                while (temp > 0)
                {
                    digit = temp % 10;

                    if (digit == i)
                    {
                        count++;
                    }
                    temp = temp / 10;
                }
                if (count > 0)
                {
                    Console.WriteLine(i + "-->" + count);
                }
            }

        }

        //static void Main(string[] args)
        //{
        //    Console.Write("Enter any Number: ");
        //    int num = Convert.ToInt32(Console.ReadLine());

        //    FindFrequencyOfDigit(num);
        //}
    }
}
