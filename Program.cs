using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice
{
	// 15, 17, 18 ...25
	internal class Program
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

		static void Main(string[] args)
		{
			PrintPattern();
		}
	}
}

