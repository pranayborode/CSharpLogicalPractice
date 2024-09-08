using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.Collection
{
    internal class GenericListEx
    {
        private static void PrintGenericList()
        {
            List<int> GenericList = new List<int>();

            GenericList.Add(1);
            GenericList.Add(2);
            GenericList.Add(3);
            GenericList.Add(4);

            foreach (int i in GenericList)
            {
                Console.Write(i + " ");
            }
        }

        private static void PrintStringList()
        {
            List<string> GenericList = new List<string>();

            GenericList.Add("C#");
            GenericList.Add(".Net");
            GenericList.Add("MVC");


            foreach (string str in GenericList)
            {
                Console.WriteLine(str);
            }
        }

        //static void Main(string[] args)
        //{
        //    PrintGenericList();
        //    PrintStringList();

        //}
    }
}
