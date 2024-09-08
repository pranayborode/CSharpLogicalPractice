using LogicalPractice.Indexers;
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

        public static void PrintNext(int i)
        {
            if (i <= 100)
            {
                Console.WriteLine(i);
                PrintNext(i+1);
            }
        }

       
        static void Main(string[] args)
        {
            PrintNext(1);
        }
    }
}

