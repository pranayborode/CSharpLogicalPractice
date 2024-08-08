using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.Array
{
	//insert an element in a specific position into an array. 
	internal class InsertElement
	{
		public static void InsertElementAtPosition(int[] arr)
		{
			Console.WriteLine("Enter Element to add");
			int num = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter Position");
			int pos = Convert.ToInt32(Console.ReadLine());

			int size = arr.Length;

			int[] newArr = new int[size + 1];

			for (int i = 0; i < size + 1; i++)
			{
				if (i < (pos - 1))
				{
					newArr[i] = arr[i];
				}
				else if (i == (pos - 1))
				{
					newArr[i] = num;
				}
				else
				{
					newArr[i] = arr[i - 1];
				}
			}

			foreach (int i in newArr)
			{
				Console.Write(i + " ");
			}
		}
		//static void Main(string[] args)
		//{
		//	int[] arr = { 1, 2, 3, 4, 5, 6 };

		//	InsertElementAtPosition(arr);
		//}
	}
}
