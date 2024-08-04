using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.Logical
{
	internal class SwapTwoNum
	{
		static void Swap<T>(ref T a, ref T b)
		{
			T temp;

			temp = a;
			a = b;
			b = temp;
		}

		//static void Main(string[] args)
		//{
		//	int a = 40, b = 80;
		//	Console.WriteLine($"Befor : a = {a}, b = {b}");

		//	Swap<int>(ref a, ref b);
		//	Console.WriteLine($"After : a = {a}, b = {b}");

		//	double c = 11, d = 22;
		//	Console.WriteLine($"Befor : c = {c}, d = {d}");

		//	Swap<double>(ref c, ref d);
		//	Console.WriteLine($"After : c = {c}, d = {d}");

		//	Console.WriteLine();
		//}
	}
}
