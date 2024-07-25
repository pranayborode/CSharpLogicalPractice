using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.Pattern
{
	internal class Q5PyramidPattern
	{
		public static void PrintPattern(int num)
		{
			for (int i = 0; i < num; i++)
			{

				for (int j = num - i; j > 1; j--)
				{
					Console.Write(" ");
				}

				for (int j = 0; j <= i; j++)
				{
					Console.Write("* ");
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
