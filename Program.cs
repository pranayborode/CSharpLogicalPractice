using MoreLinq;
using System;
using System.Collections;
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
		
		public static void MergeArray(int[,]arr)
		{
			int totalLength = 0;
			
             int row = arr.GetLength(0);
			 int col = arr.GetLength(1);

			int[] singleArray = new int[row* col];

			int index = 0;

			for(int i= 0; i< row; i++)
			{
				for(int j = 0; j<col; j++)
				{
					singleArray[index++] = arr[i, j];	
				}
			}

            Console.WriteLine(string.Join(",", singleArray));
        }
		
		static void Main(string[] args)
		{
			int[,] arr = { {1, 2, 3 },{5 , 6, 7 } };

			MergeArray(arr);
		}
	}
}

