using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.Array
{
	//WAP to swap array like input array is [2, 4, 9, 0], so your output array must be [9, 0, 2, 4] 
	internal class SwapArray
	{
		public static void Swap_Array(int[] arr)
		{
			int size = arr.Length;
			int mid = size / 2;

			for (int i = 0; i < mid; i++)
			{
				int temp = arr[i];
				arr[i] = arr[mid + i];
				arr[mid + i] = temp;
			}
			foreach (int i in arr)
			{
				Console.Write(i + " ");
			}
		}
		//static void Main(string[] args)
		//{
		//	int[] arr = { 2, 4, 9, 0 };
		//	Swap_Array(arr);
		//}
	}
}
