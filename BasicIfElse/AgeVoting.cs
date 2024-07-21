using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.Basic
{
	internal class AgeVoting
	{
		public static void CheckAge()
		{
			Console.WriteLine("Enter Your Age..");

			int age = Convert.ToInt32(Console.ReadLine());

			if (age >= 18)
			{
				Console.WriteLine("You are eligible for Voting");
			}
			else
			{
				Console.WriteLine("You are not eligible for voting");
			}

		}

		//static void Main(string[] args)
		//{
		//	CheckAge();
		//}
	}
}
