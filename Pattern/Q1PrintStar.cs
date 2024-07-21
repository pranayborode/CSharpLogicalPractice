using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.Pattern
{
	internal class Q1PrintStar
	{
		public static void PrintPattern()
		{
			for (int i = 1; i <= 6; i++)
			{
				for (int j = 1; j <= i; j++)
				{
					Console.Write("* ");
				}
				Console.WriteLine();
			}

		}
		//static void Main(string[] args)
		//{
		//	PrintPattern();
		//}
	}
}
