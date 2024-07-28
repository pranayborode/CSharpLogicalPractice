using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.Array
{
	//WAP to reverse the array itself, don’t print array in reverse – I want current array
	//reverse. Means e.g. arr[] = [3, 90, 45, 29, 37, 78] so your same array must be [78, 
	//37, 29, 45, 90, 3] by using temporary array.  
	internal class ReverseArrayUsingTemporaryArray
	{
		public static void FindReverseArray(int[] arr)
		{
			int[] tempArray = new int[arr.Length];
			int index = 0;

			for (int i = arr.Length - 1; i >= 0; i--)
			{
				if (index < arr.Length)
				{
					tempArray[index] = arr[i];
					index++;
				}
			}
			foreach (int i in tempArray)
			{
				Console.Write(i + " ");
			}
		}
		//static void Main(string[] args)
		//{
		//	int[] arr = { 3, 90, 45, 29, 37, 78 };
		//	FindReverseArray(arr);
		//}
	}
}
