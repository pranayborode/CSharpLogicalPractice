using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.Pattern
{
	internal class Q10NumberIncreasingReversePyramidPattern
	{
		public static void PrintPattern(int n)
		{
			int i, j;

			for (i = n; i >= 1; i--)
			{
				for (j = 1; j <= i; j++)
				{
					Console.Write(j + " ");
				}
				Console.WriteLine();
			}
		}

		//static void Main(string[] args)
		//{
		//	PrintPattern(6);
		//}
	}
}
