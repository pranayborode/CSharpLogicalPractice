﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice
{
	// 18 ...25
	internal class Program
	{
		public static void PrintPattern(int n)
		{
			for (int i = 1; i <= n; i++)
			{
				for (int j= 1; j<i; j++)
				{
					Console.Write(" ");
				}
				for (int j = i; j<=n; j++)
				{
					Console.Write(j+" ");
				}
				
				Console.WriteLine();
			}
		}
		static void Main(string[] args)
		{
			PrintPattern(6);
		}
	}
}

