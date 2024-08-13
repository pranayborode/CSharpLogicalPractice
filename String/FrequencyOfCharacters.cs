using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.String
{
	internal class FrequencyOfCharacters
	{
		public static void FindFrequencyOfChar(char[] ch)
		{
			for (int i = 0; i < ch.Length; i++)
			{
				int count = 1;

				if (ch[i] == '\0')
				{
					continue;
				}

				for (int j = i + 1; j < ch.Length; j++)
				{
					if (ch[i] == ch[j])
					{
						count++;
						ch[j] = '\0';
					}
				}
				Console.WriteLine(ch[i] + "->" + count);
			}
		}
		//static void Main(string[] args)
		//{
		//	char[] ch = { 'a', 'b', 'd', 'a', 'c', 'b', 'a' };
		//	FindFrequencyOfChar(ch);
		//}
	}
}
