﻿using LogicalPractice.Indexers;
using LogicalPractice.Interview;
using MoreLinq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice
{
	// 18 ...25

	internal class Program
	{

        public static void FindAverage(int[] arr)
        {
            int max = FindMax(arr);
            int min = FindMin(arr);

            int size = arr.Length;
            int sum = 0;

            for(int i = 0; i<size; i++)
            {
                sum += arr[i];
            }
            int avg = (sum - (max + min)) / (size - 2);

            Console.WriteLine("Average is : "+avg);

        }
       
        public static  int FindMax(int[]arr)
        {
            int max = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            return max;
        }

        public static int FindMin(int[]arr) {
            int min = arr[arr.Length-1]; 

            for(int i = 0; i<arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }
       
        static void Main(string[] args)
        {
            int[] arr = {12, 5, 18, 3, 25, 9 };
      
            FindAverage(arr);
        }
    }
}

