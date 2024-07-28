using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.Array
{
	internal class FindDuplicates
	{
		public static void FindDuplicateNum(int[] arr)
		{
			int count;
			for (int i = 0; i < arr.Length; i++)
			{
				count = 0;
				if (arr[i] != 0)
				{
					for (int j = i + 1; j < arr.Length; j++)
					{
						if (arr[i] == arr[j])
						{
							count++;
							arr[j] = 0;
						}
					}
					if (count >= 1)
					{
						Console.Write(arr[i] + " ");
					}
				}
			}
		}
		//static void Main(string[] args)
		//{
		//	int[] arr = { 3, 10, 4, 5, 10, 15, 4, 10, 5 };
		//	FindDuplicateNum(arr);
		//}
	}
}
