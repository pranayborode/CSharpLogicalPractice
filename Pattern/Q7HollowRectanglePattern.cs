using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.Pattern
{
	internal class Q7HollowRectanglePattern
	{
		public static void PrintPattern(int size)
		{
			for (int i = 0; i < size; i++)
			{

				for (int j = 0; j < size; j++)
				{
					if (i == 0 || j == 0 || i == size - 1 || j == size - 1)
					{
						Console.Write("* ");
					}
					else
					{
						Console.Write("  ");
					}
				}
				Console.WriteLine();

			}
		}

		//static void Main(string[] args)
		//{
		//	PrintPattern(7);
		//}
	}
}
//******
//*    *
//*    *
//*    *
//*    *
//******