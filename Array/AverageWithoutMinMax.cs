using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.Array
{
	internal class AverageWithoutMinMax
	{
		public static void CalcAvgWithoutMinMax(int[] arr)
		{
			int max = FindMax(arr);
			int min = FindMin(arr);

			int size = arr.Length;
			int sum = 0;

			for (int i = 0; i < size; i++)
			{
				sum += arr[i];
			}
			int avg = (sum - (max + min)) / (size - 2);

			Console.WriteLine($"Average Without Min and Max is {avg}");
		}

		static int FindMax(int[] arr)
		{
			int max = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] > max)
				{
					max = arr[i];
				}
			}
			return max;
		}
		static int FindMin(int[] arr)
		{
			int min = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] < min)
				{
					min = arr[i];
				}
			}
			return min;
		}
		//static void Main(string[] args)
		//{
		//	int[] arr = { 12, 5, 18, 3, 25, 9 };
		//	CalcAvgWithoutMinMax(arr);
		//}
	}
}
