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
			int[] arr = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			Stack sObj = new Stack(arr);

            Console.WriteLine("Total items : "+sObj.Count);

			for(int i = 0; i< sObj.Count; ++i)
			{
                Console.WriteLine(sObj.Pop());
            }
			Console.ReadKey();
        }
	}
}

