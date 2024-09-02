using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.String
{
	internal class ReplaceDuplicate
	{
		public static void RemoveDouplicatChar(string str)
		{

			char[] ch = str.ToCharArray();

			for (int i = 0; i < str.Length; i++)
			{
				for (int j = i + 1; j < str.Length; j++)
				{
					if (ch[i] == ch[j])
					{
						ch[j] = '#';
					}
				}
			}

			str = new string(ch);
			Console.WriteLine(str);
		}

		//static void Main(string[] args)
		//{
		//	string str = "Book";
		//	RemoveDouplicatChar(str);
		//}
	}
}
