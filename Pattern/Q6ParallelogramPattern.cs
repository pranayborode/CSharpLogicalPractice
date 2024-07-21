using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.Pattern
{
	internal class Q6ParallelogramPattern
	{
		public static void PrintPattern(int size)
		{
			for (int row = 1; row <= size; row++)
			{
				for (int col = 1; col <= row; col++)
				{
					Console.Write(" ");
				}
				for (int col = 1; col <= size; col++)
				{
					Console.Write("*");
				}

				Console.WriteLine();
			}
		}

		//static void Main(string[] args)
		//{
		//	PrintPattern(5);
		//}
	}
}
