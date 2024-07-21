using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.Logical
{
	internal class PrintAllAlphabets
	{
		public static void PrintAlphabets()
		{
			for (int i = 97; i <= 122; i++)
			{
				Char c = (Char)i;
				Console.WriteLine(c);
			}
		}

		//static void Main(string[] args)
		//{
		//	PrintAlphabets();
		//}
	}
}
