using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.BasicIfElse
{
	internal class ElectricityBill
	{

		public static void CalcElectricityBill()
		{
			Console.WriteLine("Enter No of Units");

			int units = Convert.ToInt32(Console.ReadLine());

			double billAmount;

			if (units <= 50)
			{
				billAmount = units * 2;
			}
			else if (units <= 80)
			{
				billAmount = (units * 2) + ((units - 50) * 3);
			}
			else if (units <= 100)
			{
				billAmount = (units * 2) + (units * 3) + ((units - 80) * 4);
			}
			else
			{
				billAmount = (units * 2) + (units * 3) + (units * 4) + ((units - 100) * 7);
			}

			billAmount += 100;

			Console.WriteLine("Total Bill is :" + billAmount);
		}

		//static void Main(string[] args)
		//{
		//	CalcElectricityBill();

		//}
	}
}
