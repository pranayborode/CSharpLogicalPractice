using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.Array
{
	internal class TableArray
	{
		public static int[] PrintTableArray(int num)
		{
			int[] table = new int[10];

			for (int i = 0; i < table.Length; i++)
			{
				table[i] = num * (i + 1);
			}
			return table;
		}
		//static void Main(string[] args)
		//{
		//	Console.Write("Enter Number : ");
		//	int num = Convert.ToInt32(Console.ReadLine());

		//	int[] table = PrintTableArray(num);

		//	foreach (int i in table)
		//	{
		//		Console.WriteLine(i + " ");
		//	}
		//}
	}
}
