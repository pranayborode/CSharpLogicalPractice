using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.Array
{
	internal class MaxValue
	{
		public static void FindMaxValue(int[] arr)
		{
			int max = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] > max)
				{
					max = arr[i];
				}
			}
			Console.WriteLine($"Max value in given array is : {max}");
		}
		//static void Main(string[] args)
		//{
		//	int[] arr = { 20, 0, 31, 45, 100, 1, 105, 90 };
		//	FindMaxValue(arr);
		//}
	}
}
