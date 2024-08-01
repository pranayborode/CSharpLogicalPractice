using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice
{
	// 18 ...25
	internal class Program
	{
		public static void MaxCharacter(char[]arr)
		{
			int size = arr.Length;
			char maxChar = arr[size - 1];

			for(int i = 0; i<size; i++)
			{
				if (arr[i] > maxChar)
				{
					maxChar = arr[i];
				}
			}
            Console.WriteLine("Max Cahracter is : "+maxChar);
        }
		static void Main(string[] args)
		{
			char[] arr = { 'A', 'D', 'E', 'x', 'R', 'Z','p' };
			MaxCharacter (arr);
		}
	}
}

