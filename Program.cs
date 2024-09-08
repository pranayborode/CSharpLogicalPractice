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

       
        static void Main(string[] args)
        {
           Student s = new Student();

            s[0] = "Pranay";
            s[1] = "Gaurav";
            s[2] = "Rahul";
            s[3] = "Saurabh";
            s[4] = "Ganesh";

            Console.WriteLine(s[2]);
        }
    }
}

