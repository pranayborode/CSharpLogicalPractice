﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.Array
{
	//find the common elements between two arrays. 
	internal class CommonElements
	{
		public static void FindCommonElements(int[] arr1, int[] arr2)
		{
			for (int i = 0; i < arr1.Length; i++)
			{
				for (int j = 0; j < arr2.Length; j++)
				{
					if (arr1[i] == arr2[j])
					{
						Console.Write(arr1[i] + " ");
						break;
					}
				}
			}
		}
		//static void Main(string[] args)
		//{
		//	int[] arr1 = { 12, 23, 34, 67, 78, 91, 56 };
		//	int[] arr2 = { 39, 25, 15, 23, 55, 91, 66, 12 };
		//	Console.WriteLine("Common Elements are : ");
		//	FindCommonElements(arr1, arr2);
		//}
	}
}
