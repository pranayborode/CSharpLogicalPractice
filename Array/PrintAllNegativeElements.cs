using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.Array
{
	internal class PrintAllNegativeElements
	{
		public static void PrintNegativeElements(int[] arr)
		{
			for (int i = 0; i < arr.Length + 1; i++)
			{
				if (arr[i] < 0)
				{
					Console.Write(arr[i] + " ");
				}
			}
		}
		//static void Main(string[] args)
		//{
		//	int[] arr = { 1, -2, 5, -6, -3, 9, -10, 0 };
		//	PrintNegativeElements(arr);
		//}
	}
}
