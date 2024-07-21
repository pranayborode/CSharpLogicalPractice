using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.BasicIfElse
{
	internal class BiggestNumber
	{
		public static void FindBiggestNum()
		{
			Console.WriteLine("Enter Num1");
			int num1 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter Num2");
			int num2 = Convert.ToInt32(Console.ReadLine());

			if (num1 > num2)
			{
				Console.WriteLine($"{num1} is Greater Than {num2}");
			}
			else
			{
				Console.WriteLine($"{num2} is Greater Than {num1}");
			}

		}

		//static void Main(string[] args)
		//{
		//	FindBiggestNum();
		//}
	}
}
