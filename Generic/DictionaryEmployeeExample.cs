using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.Generic
{
	public class emp
	{
		private string name;
		private int salary;

		public emp(string name, int salary)
		{
			this.name = name;
			this.salary = salary;
		}
		public override string ToString()
		{
			StringBuilder sb = new StringBuilder(200);
			sb.AppendFormat("{0},{1}", name, salary);

			return sb.ToString();
		}

	}
	internal class DictionaryEmployeeExample
	{
		static void Main(string[] args)
		{
			Dictionary<string, emp> dObj = new Dictionary<string, emp>(2);

			emp tom = new emp("tom", 2000);
			dObj.Add("tom", tom);   // key,value
			emp john = new emp("john", 4000);
			dObj.Add("john", john);

			foreach (Object str in dObj.Values)
			{
				Console.WriteLine(str);
			}

			Console.ReadKey();
		}
	}
}
