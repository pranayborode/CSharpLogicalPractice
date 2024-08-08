using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.BasicLogical
{
	delegate void Calculator(int x, int y);
	internal class DelegateExample
	{
		public static void Add(int a, int b)
		{
			Console.WriteLine("Add: " + (a + b));
		}

		public static void Mul(int a, int b)
		{
			Console.WriteLine("Mul: " + a * b);
		}
		//static void Main(string[] args)
		//{
		//	Calculator calc = new Calculator(Add);
		//	//calc(20, 30);

		//	// multiicase delegate
		//	calc += Mul;
		//	calc(20, 30);

		//	Console.WriteLine();
		//}
	}
}
