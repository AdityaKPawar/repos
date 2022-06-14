using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

namespace abc
{
	public class class1
	{
		static void Main(string[] args)
		{
			m3("Aditya", greet);
		}
		static void m3(string name, Action<string> functionpointer)
		{
			Console.WriteLine("welcome");
			functionpointer(name);

		}
		static void greet(string nm)
		{
			Console.WriteLine(nm + " , Welcome to online tutorial");
		}
	}
}