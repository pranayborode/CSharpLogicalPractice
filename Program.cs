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
		
		
		static void Main(string[] args)
		{
			var num = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 , 14, 15 };

			var result = num.Batch(4);

			foreach (var item in result)
			{
				foreach(var item2 in item)
				{
                    Console.Write(item2 + " ");
                }
                Console.WriteLine();
            }
		}
	}
}

