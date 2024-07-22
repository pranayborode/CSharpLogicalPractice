using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.Pattern
{
	internal class Q8NumberTrianglePattern
	{
		public static void PrintPattern(int n)
		{
			for (int i = 1; i <= n; i++)
			{
				for (int j = 1; j <= n - i; j++)
				{
					Console.Write(" ");
				}

				for (int j = 1; j <= i; j++)
				{
					Console.Write(i + " ");
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
