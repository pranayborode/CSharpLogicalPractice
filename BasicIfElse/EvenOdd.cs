﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.BasicIfElse
{
	internal class EvenOdd
	{

		public static void CheckEvenOdd()
		{
			Console.WriteLine("Enter Numner");

			int num = Convert.ToInt32(Console.ReadLine());

			if (num % 2 == 0)

				Console.WriteLine($"{num} is Even");
			else
				Console.WriteLine($"{num} is Odd");
		}

		//static void Main(string[] args)
		//{
		//	CheckEvenOdd();

		//}
	}
}
