using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.Logical
{
	internal class SumOfEvenNo
	{
		public static int SumOfEvenNum(int num)
		{
			int sum = 0;
			for (int i = 1; i <= num; i++)
			{
				if (i % 2 == 0)
				{
					sum += i;
				}
			}

			return sum;
		}

		//static void Main(string[] args)
		//{
		//	Console.WriteLine("Enter Number");
		//	int num = Convert.ToInt32(Console.ReadLine());

		//	int sum = SumOfEvenNum(num);

		//	Console.WriteLine($"Sum of all Even Numbers : {sum}");
		//}
	}
}
