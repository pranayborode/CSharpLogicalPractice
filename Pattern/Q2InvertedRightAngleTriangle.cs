﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.Pattern
{
	internal class Q2InvertedRightAngleTriangle
	{
		public static void PrintPattern()
		{
			for (int i = 5; i >= 0; i--)
			{
				for (int j = 0; j <= i; j++)
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

//******
//*****
//****
//***
//**
//*