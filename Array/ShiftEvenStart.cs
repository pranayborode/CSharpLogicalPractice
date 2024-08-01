using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.Array
{
	// WAP to arrange the elements of an given array of integers where all Even integers 
	// appear before all the Odd integers. 
	internal class ShiftEvenStart
	{
		public static void ShiftAllEvenAtStart(int[] arr)
		{
			int size = arr.Length;

			for (int i = 0; i < size; i++)
			{
				if (arr[i] % 2 == 0)
				{
					continue;
				}
				else
				{
					for (int j = size - 1; j >= 0 && i < j; j--)
					{
						if (arr[j] % 2 == 0)
						{
							int temp = arr[i];
							arr[i] = arr[j];
							arr[j] = temp;
							break;
						}
					}
				}
			}
			foreach (int i in arr)
			{
				Console.Write(i + " ");
			}
		}
		//static void Main(string[] args)
		//{
		//	int[] arr = { 3, 4, 1, 7, 2, 9, 8 };
		//	ShiftAllEvenAtStart(arr);
		//}
	}
}
