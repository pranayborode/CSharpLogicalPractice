using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.Array
{
	//WAP to find min character in character array. 
	//Means e.g. arr[] = [‘A’, ‘D’, ‘E’, ‘x’, ‘z’, ‘R’], so min character is ‘A’. 
	internal class MinCharacterArray
	{
		public static void MinCharacter(char[] arr)
		{
			char minCahr = arr[0];

			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] < minCahr)
				{
					minCahr = arr[i];
				}
			}
			Console.WriteLine("Min Character is : " + minCahr);
		}
		//static void Main(string[] args)
		//{
		//	char[] arr = { 'A', 'D', 'E', 'x', 'R', 'Z' };
		//	MinCharacter(arr);
		//}
	}
}
