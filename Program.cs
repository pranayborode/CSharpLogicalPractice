﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice
{
	// 18 ...25

	internal class Program
	{
		public static void RemoveDouplicatChar(string str)
		{
			string s = "";
			char[] ch = str.ToCharArray();
			bool found;

			for(int i = 0; i< str.Length; i++)
			{
				found = false;

				for(int j = i+1; j<str.Length; j++)
				{
					if (ch[i] == ch[j])
					{
						found = true;
						break;
					}
				}
				if(found == false)
				{
					s += ch[i];
				}
			}
            Console.WriteLine(s);
        }
		
		static void Main(string[] args)
		{
			string str = "Book";


			RemoveDouplicatChar (str);
		}
	}
}

