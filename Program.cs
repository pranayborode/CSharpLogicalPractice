using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice
{
	// 18 ...25

	internal class Program
	{
		
		public static int[] CountIntegers(int n, int val, int[] arr)
		{
			int[] counts = new int[3];

			int smaller = 0, equal = 0, greater = 0;

			for(int i = 0; i<n; i++)
			{
				if (arr[i] < val)
				{
					smaller++;
				}
				else if (arr[i] == val)
				{
					equal++;
				}
				else
				{
					greater++;
				}
			}

			counts[0] = smaller;
			counts[1] = equal;
			counts[2] = greater;

			return counts;
		}

		static void Main(string[] args)
		{
            Console.WriteLine("Enter n");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter val");
            int val = Convert.ToInt32(Console.ReadLine());
			int[] arr = new int[n];

			for(int i =	0; i<n; i++)
			{
                Console.Write($"Enter {i} : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
			}

			int[] result = CountIntegers(n, val, arr);

			foreach(int i in result)
			{
                Console.Write(i);
            }
		}
	}
}

