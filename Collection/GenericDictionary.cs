using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.Collection
{
    internal class GenericDictionary
    {
        private static void PrintGenericDictionary()
        {
            Dictionary<int, string> GenericDictionar = new Dictionary<int, string>();

            GenericDictionar.Add(1, "C#");
            GenericDictionar.Add(2, "Dot Net");
            GenericDictionar.Add(3, "MVC");

            foreach (KeyValuePair<int, string> kvp in GenericDictionar)
            {
                Console.WriteLine(kvp.Key + " - " + kvp.Value);
            }
        }


        //static void Main(string[] args)
        //{
        //    PrintGenericDictionary();

        //}
    }
}
