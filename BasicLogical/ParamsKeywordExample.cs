using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.BasicLogical
{
	internal class ParamsKeywordExample
	{
		public static int Add(params int[] listNum)
		{
			int total = 0;

			foreach (var i in listNum)
			{
				total += i;
			}
			return total;
		}
		//static void Main(string[] args)
		//{
		//	int total = Add(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
		//	Console.WriteLine(total);
		//	Console.WriteLine();
		//}
	}
}
