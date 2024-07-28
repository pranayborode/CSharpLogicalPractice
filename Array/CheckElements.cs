using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.Array
{
	// WAP to check if an array of integers contains two specified elements 65 and 77. 
	internal class CheckElements
	{
		public static bool Check_Elements(int[] arr)
		{
			bool status1 = false;
			bool status2 = false;

			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] == 65)
				{
					status1 = true;
				}
				else if (arr[i] == 77)
				{
					status2 = true;
				}

				if (status1 && status2)
				{
					break;
				}
			}
			return status1 && status2;
		}
		//static void Main(string[] args)
		//{
		//	int[] arr = { 12, 34, 65, 23, 77, 56 };
		//	if (Check_Elements(arr))
		//	{
		//		Console.WriteLine("Array contain elements 65 and 77");
		//	}
		//	else
		//	{
		//		Console.WriteLine("Array Does not contain elements 65 and 77");
		//	}
		//}
	}
}
