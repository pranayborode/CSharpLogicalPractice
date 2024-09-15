using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.Logical
{
    internal class FindMissingNumber
    {
        public static void FindMissingNum(int[] arr)
        {

            int size = arr.Length;
            int start = arr[0];
            int end = arr[size - 1];
            bool status = false;

            for (int i = start; i <= end; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (arr[j] == i)
                    {
                        status = true;
                        break;
                    }
                    else
                    {
                        status = false;
                    }

                }
                if (status == false)
                {
                    Console.WriteLine($"Missing num is : {i}");
                }
            }
        }



        //static void Main(string[] args)
        //{
        //    int[] arr = { 1, 2, 3, 4, 6, 7 };

        //    FindMissingNum(arr);
        //}
    }
}
