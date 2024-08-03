using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.Array
{
	//26. WAP to print minimum in rows. Means e.g. arr[][] = {{22, 31, 9}, {12, 25, 16}} 
	//output is: 9 and 12. s
	internal class PrintMaxMinInRow
	{
		public static void FindRowWiseMax(int[,] arr)
		{
			int rowCount = arr.GetLength(0);
			int colCount = arr.GetLength(1);
			for (int i = 0; i < rowCount; i++)
			{
				int maxInRow = arr[i, 0];
				for (int j = 1; j < colCount; j++)
				{
					if (arr[i, j] > maxInRow)
					{
						maxInRow = arr[i, j];
					}
				}
				Console.WriteLine($"Max Element in Row {i + 1} : {maxInRow}");
			}
		}

		//static void Main(string[] args)
		//{
		//	int[,] arr = { { 22, 31, 9 }, { 12, 25, 16 } };
		//	FindRowWiseMax(arr);
		//}
	}
}
