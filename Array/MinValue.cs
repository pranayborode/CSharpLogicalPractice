using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.Array
{
	internal class MinValue
	{
		public static void FindMinValue(int[] arr)
		{
			int min = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] < min)
				{
					min = arr[i];
				}
			}
			Console.WriteLine($"Min value in given array is {min}");
		}
		//static void Main(string[] args)
		//{
		//	int[] arr = { -20, 0, -25, 15, 19, 37, 23 };
		//	FindMinValue(arr);
		//}
	}
}
