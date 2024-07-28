using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.Array
{
	// WAP to replace all the 0’s with 1’s in your array. 
	//Your array is [26, 0, 67, 45, 0, 78, 54, 34, 10, 0, 34]  
	internal class Replace0With1
	{
		public static void ReplaceZerosWithOnes(int[] arr)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] == 0)
				{
					arr[i] = 1;
				}
			}
			foreach (int i in arr)
			{
				Console.Write(i + " ");
			}
		}
		//static void Main(string[] args)
		//{
		//	int[] arr = { 26, 0, 67, 45, 0, 78, 54, 34, 10, 0, 34 };
		//	ReplaceZerosWithOnes(arr);
		//}
	}
}
