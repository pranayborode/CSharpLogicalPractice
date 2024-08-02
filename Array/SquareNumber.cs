using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.Array
{
	//21. WAP to display all square number in array. 
	//Means e.g. arr[] = [23, 43, 25, 49, 12, 9, 78, 66, 39, 0] so output is 25, 49, 9.  
	internal class SquareNumber
	{
		public static void CheckSqrNum(int[] arr)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				int sqrt = (int)Math.Sqrt(arr[i]);

				if ((arr[i] == (sqrt * sqrt)) && arr[i] != 0)
				{
					Console.Write(arr[i] + " ");
				}
			}
		}
		//static void Main(string[] args)
		//{
		//	int[] arr = { 23, 43, 25, 49, 12, 9, 78, 66, 39, 0 };
		//	CheckSqrNum(arr);
		//}
	}
}
