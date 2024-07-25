using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.Pattern
{
	internal class Q12ZeroOneTrianglePattern
	{
		public static void PrintPattern(int n)
		{

			for (int i = 1; i <= n; i++)
			{
				for (int j = 1; j <= i; j++)
				{
					if ((i + j) % 2 == 0)
					{
						Console.Write(1 + " ");
					}
					else
					{
						Console.Write(0 + " ");
					}

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
