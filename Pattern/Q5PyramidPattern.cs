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
			for (int i = 1; i <= num; i++)
			{
				for (int j = 1; j <= num - i; j++)
				{
					Console.Write(" ");
				}
				for (int k = 1; k < i*2; k++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
			for(int i= num-1; i>=1; i--)
			{
				for (int j = 1; j <= num - i; j++)
				{
					Console.Write(" ");
				}
				for (int k = 1; k < i * 2; k++)
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
