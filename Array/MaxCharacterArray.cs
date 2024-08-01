using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.Array
{
	//18. WAP to find max character in character array. Means e.g. arr[] = [‘A’, ‘D’, ‘E’, ‘x’, 
	//‘R’, ‘Z’, ‘p’], so max character is ‘x’.  
	internal class MaxCharacterArray
	{
		public static void MaxCharacter(char[] arr)
		{
			int size = arr.Length;
			char maxChar = arr[size - 1];

			for (int i = 0; i < size; i++)
			{
				if (arr[i] > maxChar)
				{
					maxChar = arr[i];
				}
			}
			Console.WriteLine("Max Cahracter is : " + maxChar);
		}
		static void Main(string[] args)
		{
			char[] arr = { 'A', 'D', 'E', 'x', 'R', 'Z', 'p' };
			MaxCharacter(arr);
		}
	}
}
