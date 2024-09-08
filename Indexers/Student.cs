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
    }
}
