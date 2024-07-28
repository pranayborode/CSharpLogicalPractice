using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.Pattern
{
	internal class Q19ReverseNumberTrianglePattern
	{
		public static void PrintPattern(int n)
		{
			for (int i = 1; i <= n; i++)
			{
				for (int j = 1; j < i; j++)
				{
					Console.Write(" ");
				}
				for (int j = i; j <= n; j++)
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
//1 2 3 4 5 6
// 2 3 4 5 6
//  3 4 5 6
//   4 5 6
//	  5 6
//	   6