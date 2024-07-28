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
		public static bool CheckArrayEquality(int[]arr1, int[]arr2)
		{
			if(arr1.Length != arr2.Length)
			{
				return false;
			}
			
			SortArray(arr1);
			SortArray(arr2);

			for (int i=0; i<arr1.Length; i++)
			{
				if (arr1[i] != arr2[i])
				{
					return false;
				}
				
			}
			return true;
		}
		public static int[] SortArray(int[]arr)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				for (int j = i + 1; j < arr.Length; j++)
				{
					if (arr[i] > arr[j])
					{
						int temp = arr[i];
						arr[i] = arr[j];
						arr[j] = temp;
					}
				}
			}
			return arr;
		}
		static void Main(string[] args)
		{
			int[] arr1 = { 12, 22, 32, 42, 52, 62 };
			int[] arr2 = { 52, 32, 62, 12, 42, 22 };
		
			if (CheckArrayEquality(arr1,arr2))
			{
                Console.WriteLine("Both Arrays are Equal");
			}
			else
			{
                Console.WriteLine("Both Arrays are not Equal");
            }
		}
	}
}

