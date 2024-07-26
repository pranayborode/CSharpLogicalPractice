using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.Pattern
{
	internal class Q18ReverseLeftHalfPyramidPattern
	{
		public static void PrintPattern(int n)
		{
			for (int i = n; i > 0; i--)
			{
				for (int j = 0; j < n - i; j++)
				{
					Console.Write(" ");
				}
				for (int j = 0; j < i; j++)
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
//******
// *****
//  ****
//   ***
//	**
//	 *