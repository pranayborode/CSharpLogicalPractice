using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.Collection
{
    internal class GenericSortedList
    {
        private static void PrintGenericSortedList()
        {
            SortedList<int, string> keyValuePairs = new SortedList<int, string>();

            keyValuePairs.Add(2, "MVC");
            keyValuePairs.Add(3, "dot net");
            keyValuePairs.Add(1, "Sql Server");
            keyValuePairs.Add(4, "C#");

            foreach (KeyValuePair<int, string> kvp in keyValuePairs)
            {
                Console.WriteLine(kvp.Key + " - " + kvp.Value);
            }
        }
        //static void Main(string[] args)
        //{
        //    PrintGenericSortedList();

        //}
    }
}
