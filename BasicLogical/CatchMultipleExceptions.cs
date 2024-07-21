using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.BasicLogical
{
	internal class CatchMultipleExceptions
	{

		public static void CatchExceptions()
		{
			try
			{
				int[] num = { 1, 2, 3 };
				Console.WriteLine(num[4]); // This will throw an IndexOutOfRangeException
			}
			catch (Exception ex) when (ex is IndexOutOfRangeException || ex is ArithmeticException)
			{
				Console.WriteLine("Handled IndexOutOfRangeException or ArithmeticaException");
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Handled {ex.GetType()} exception");
			}
		}

		//static void Main(string[] args)
		//{
		//	CatchExceptions();
		//}
	}
}
