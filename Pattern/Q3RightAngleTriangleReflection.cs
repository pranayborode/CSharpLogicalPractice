using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.Pattern
{
	internal class Q3RightAngleTriangleReflection
	{
		public static void PrintPattern(int size)
		{
			for (int i = 1; i <= size; i++)
			{
				for (int j = 1; j <= size - i; j++)
				{
					Console.Write(" ");
				}
				for (int k = 1; k <= i; k++)
				{
					Console.Write("*");
				}

				Console.WriteLine();
			}
		}

		//static void Main(string[] args)
		//{
		//	PrintPattern(5);
		//}
	}
}

//     *
//    **
//   ***
//  ****
// *****
//******