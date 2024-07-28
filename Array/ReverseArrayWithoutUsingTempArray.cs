using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.Array
{
	internal class ReverseArrayWithoutUsingTempArray
	{
		public static void FindReverseArray(int[] arr)
		{
			int start = 0;
			int end = arr.Length - 1;

			while (start < end)
			{
				int temp = arr[start];
				arr[start] = arr[end];
				arr[end] = temp;
				start++;
				end--;
			}

			foreach (int i in arr)
			{
				Console.Write(i + " ");
			}
		}
		static void Main(string[] args)
		{
			int[] arr = { 3, 90, 45, 29, 37, 78 };
			FindReverseArray(arr);
		}
	}
}
