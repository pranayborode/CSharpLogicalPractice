using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.BasicLogical
{
	internal class Q1PrintEvenNumbers
	{
		//1. WAP to print even numbers from 121 to 229 using for loop. 
		private static void PrintEvenNo()
		{
			for (int i = 121; i <= 229; i++)
			{
				if (i % 2 == 0)
				{
					Console.WriteLine(i);
				}
			}
		}
		//static void Main(string[] args)
		//{
		//	PrintEvenNo();
		//}

		//2. WAP to print odd numbers from 521 to 229 using while loop. 
		private static void PrintOddNo()
		{
			for (int i = 521; i >= 229; i--)
			{
				if (i % 2 != 0)
				{
					Console.WriteLine(i);
				}
			}
		}

		//static void Main(string[] args)
		//{
		//	PrintOddNo();
		//}
	}
}
