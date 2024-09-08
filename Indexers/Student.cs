using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.Indexers
{
    internal class Student
    {
        string[] names = new string[5];

        public string this[int i]
        {
            get {return names[i];}
            set { names[i] = value; }

        }

        //static void Main(string[] args)
        //{
        //    Student s = new Student();

        //    s[0] = "Pranay";
        //    s[1] = "Gaurav";
        //    s[2] = "Rahul";
        //    s[3] = "Saurabh";
        //    s[4] = "Ganesh";

        //    Console.WriteLine(s[2]);
        //}
    }
}
