using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.Array
{
	internal class MaxMinValue
	{
		public static void FindMaxMInValue(int[] arr)
		{
			int size = arr.Length;
			int maxValue = arr[0];
			int minValue = arr[0];

			for (int i = 0; i < size; i++)
			{
				if (arr[i] < minValue)
				{
					minValue = arr[i];
				}
				else if (arr[i] > maxValue)
				{
					maxValue = arr[i];
				}
			}

			Console.WriteLine($"MaxValue : {maxValue}");
			Console.WriteLine($"MinValue : {minValue}");
		}
		static void Main(string[] args)
		{
			int[] arr = { 2, 3, 6, 9, 5, 0 };
			FindMaxMInValue(arr);
		}
	}
}
