using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.Pattern
{
	internal class Q15ButterflyStarPattern
	{
		public static void PrintPattern(int n)
		{
			for (int i = 1; i <= n; i++)
			{
				for (int j = 1; j <= i; j++)
				{
					Console.Write("*");
				}

				for (int k = 1; k <= (2 * (n - i)); k++)
				{
					Console.Write(" ");
				}

				for (int j = 1; j <= i; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
			for (int i = n; i >= 1; i--)
			{
				for (int j = 1; j <= i; j++)
				{
					Console.Write("*");
				}

				for (int k = 1; k <= (2 * (n - i)); k++)
				{
					Console.Write(" ");
				}

				for (int j = 1; j <= i; j++)
				{
					Console.Write("*");
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

//*          *
//**        **
//***      ***
//****    ****
//*****  *****
//************
//************
//*****  *****
//****    ****
//***      ***
//**        **
//*          *