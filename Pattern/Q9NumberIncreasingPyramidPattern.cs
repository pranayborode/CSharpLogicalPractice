﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.Pattern
{
	internal class Q9NumberIncreasingPyramidPattern
	{

		public static void PrintPattern(int n)
		{
			int i, j;

			for (i = 1; i <= n; i++)
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
