using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.Array
{
	internal class SwapEnds
	{
		public static void SwapEndsOfArray(int[] arr)
		{
			int start = arr[0];
			int end = arr[arr.Length - 1];

			arr[0] = end;
			arr[arr.Length - 1] = start;

			foreach (int i in arr)
			{
				Console.Write(i + " ");
			}
		}
		//static void Main(string[] args)
		//{
		//	int[] arr = { 1, -2, 5, -6, -3, 9, -10, 0 };
		//	SwapEndsOfArray(arr);
		//}
	}
}

