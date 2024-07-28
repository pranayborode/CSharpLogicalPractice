using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.Array
{
	internal class ReverseOrder
	{
		public static void FindReverseArray(int[] arr)
		{
			for (int i = arr.Length - 1; i >= 0; i--)
			{
				Console.Write(arr[i] + " ");
			}
		}
		//static void Main(string[] args)
		//{
		//	int[] arr = { 3, 90, 45, 29, 37, 78 };
		//	Console.Write("Original Array: ");
		//	foreach (int i in arr)
		//	{
		//		Console.Write(i.ToString() + " ");
		//	}
		//	Console.WriteLine();
		//	Console.Write("Reverse Array: ");
		//	FindReverseArray(arr);
		//}
	}
}
