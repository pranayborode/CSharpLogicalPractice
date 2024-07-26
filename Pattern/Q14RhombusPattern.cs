using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.Pattern
{
	internal class Q14RhombusPattern
	{
		public static void PrintPattern(int n)
		{
			for (int i = 1; i <= n; i++)
			{
				for (int j = n - i; j >= 1; j--)
				{
					Console.Write(" ");
				}

				for (int j = 1; j <= n; j++)
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

//     ******
//    ******
//   ******
//  ******
// ******
//******