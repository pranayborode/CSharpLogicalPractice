using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.String
{
	internal class Anagram
	{
		public static bool CheckAnagram(string s1, string s2)
		{
			s1 = s1.ToLower();
			s2 = s2.ToLower();

			if (s1.Length != s2.Length)
			{
				return false;
			}
			else
			{
				char[] ch1 = s1.ToCharArray();
				char[] ch2 = s2.ToCharArray();

				SortArray(ch1);
				SortArray(ch2);

				for (int i = 0; i < ch1.Length; i++)
				{
					if (ch1[i] != ch2[i])
					{
						return false;
					}
				}
			}
			return true;
		}

		public static void SortArray(char[] ch)
		{
			for (int i = 0; i < ch.Length; i++)
			{
				for (int j = i + 1; j < ch.Length; j++)
				{
					if (ch[i] > ch[j])
					{
						char temp = ch[i];
						ch[i] = ch[j];
						ch[j] = temp;
					}
				}
			}
		}
		//static void Main(string[] args)
		//{
		//	string s1 = "Race";
		//	string s2 = "Care";

		//	if (CheckAnagram(s1, s2))
		//	{
		//		Console.WriteLine($"{s1} and {s2} are Anagram");
		//	}
		//	else
		//	{
		//		Console.WriteLine($"{s1} and {s2} are not Anagram");
		//	}
		//}
	}
}
