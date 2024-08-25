using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.Struct
{
	internal struct Product
	{
		private int id;
        private int price;
        private int total;
       
        public static void CalcTotal()
        {
            Console.WriteLine("Method");
        }
    }
         
    public class Shop : Product
    {
        
    }
}
