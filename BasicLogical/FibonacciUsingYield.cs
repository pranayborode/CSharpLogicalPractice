using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.BasicLogical
{
	internal class FibonacciUsingYield
	{
		public static IEnumerable<int> Fibonacci(int count)
		{
			int a = 0, b = 1;

			for (int i = 0; i < count; i++)
			{
				yield return a;
				int temp = a;
				a = b;
				b = temp + b;
			}
		}

		//static void Main(string[] args)
		//{

		//	foreach (int num in Fibonacci(10))
		//	{
		//		Console.Write(num + " ");
		//	}
		//}
	}
}
