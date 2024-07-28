using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.Array
{
	//Write a Java program to find a missing number in an array.Means e.g.array has 1 
	//to n element in sequence(n can be 50 or 100) arr[] = [1, 2, 3, 4, 6, 7] So missing no is 5  
	internal class MissingNumber
	{
		public static void FindMissingNum(int[] arr)
		{
			int size = arr.Length;
			int start = arr[0];
			int end = arr[size - 1];
			bool status = false;

			for (int i = start; i <= end; i++)
			{
				for (int j = 0; j < size; j++)
				{
					if (arr[j] == i)
					{
						status = true;
						break;
					}
					else
					{
						status = false;
					}
				}
				if (status == false)
				{
					Console.WriteLine($"Missing No is : {i}");
				}
			}
		}
		//static void Main(string[] args)
		//{
		//	int[] arr = { 1, 2, 3, 4, 6, 7 };
		//	FindMissingNum(arr);
		//}
	}
}
