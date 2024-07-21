using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.BasicIfElse
{
	internal class NumOfDaysSwitch
	{
		public static void PrintNoOfDays()
		{
			Console.WriteLine("Enter Month No.");

			int monthNo = Convert.ToInt32(Console.ReadLine());

			switch (monthNo)
			{
				case 1:
				case 3:
				case 5:
				case 7:
				case 8:
				case 10:
				case 12:
					Console.WriteLine("31 Days");
					break;
				case 4:
				case 6:
				case 9:
				case 11:
					Console.WriteLine("30 Days");
					break;
				case 2:
					Console.WriteLine("Enter Year");
					int year = Convert.ToInt32(Console.ReadLine());
					if (((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0)))
					{
						Console.WriteLine("29 Days");
					}
					else
					{
						Console.WriteLine("28 Days");
					}
					break;

				default:
					Console.WriteLine("Enter Valid Input");
					break;

			}
		}
		//static void Main(string[] args)
		//{
		//	PrintNoOfDays();
		//}
	}
}
