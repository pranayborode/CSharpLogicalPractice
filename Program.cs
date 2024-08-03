using System;
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
		public static void DeleteSpacificPositionArray(int[] arr)
		{
            Console.WriteLine("Enter Position value to delete element : ");
            int pos = Convert.ToInt32(Console.ReadLine());
			int size = arr.Length;

			for(int i = pos-1; i < size-1; i++)
			{
				arr[i] = arr[i + 1];
			}
			size = size - 1;

			for(int i = 0; i<size; i++)
			{
				Console.WriteLine(arr[i] +" ");
            }
        }

		static void Main(string[] args)
		{
			int []arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
			DeleteSpacificPositionArray(arr);
		}
	}
}

