using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.Array
{
	internal class NegativeAtStart
	{
		public static void PrintNegativeAtStart(int[] arr)
		{
			int size = arr.Length;
			for (int i = 0; i < size; i++)
			{
				if (arr[i] < 0)
				{
					continue;
				}
				else
				{
					for (int j = size - 1; j >= 0 && i < j; j--)
					{
						if (arr[j] < 0)
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
		//	int[] arr = { 1, -2, 3, -4, 0, -5 };
		//	PrintNegativeAtStart(arr);
		//}
	}
}
