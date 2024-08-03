﻿using System;
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
		public static void SortingArray(int[] arr)
		{
			int maxArray = arr[0];
			int secMax = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] > maxArray)
				{
					secMax = maxArray;
					maxArray = arr[i];
				}
				else if(secMax < arr[i] && arr[i] != maxArray)
				{
					secMax = arr[i];
				}
			}
            Console.WriteLine("Second Max : "+secMax);
        }
		static void Main(string[] args)
		{
			int[] arr = { 12, 35, 30, 45, 32,0 };
			SortingArray(arr);
		}
	}
}

