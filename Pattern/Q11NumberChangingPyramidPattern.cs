﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.Pattern
{
	internal class Q11NumberChangingPyramidPattern
	{
		public static void PrintPattern(int n)
		{
			int num = 1;

			for (int i = 1; i <= n; i++)
			{
				for (int j = 1; j <= i; j++)
				{
					Console.Write(num + " ");
					num++;
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


//1
//2 3
//4 5 6
//7 8 9 10
//11 12 13 14 15
//16 17 18 19 20 21