using System;
using System.Collections;
namespace AB
{

	public class ArrayLIst
	{
		public static void Main(string[] args)
		{
			ArrayList al = new ArrayList();
			al.Add(200);
			al.Add("Omkar");
			al.Add(9.5);
			al.Add(900);
			al.Add(200);
			al.Add(8765);
			al.Insert(1, "Rohit");

			foreach (var i in al)
				Console.WriteLine(i);
			Console.WriteLine("*****************");
			for (int i = 0; i < al.Count; i++)
				Console.WriteLine(al[i]);

		}
	}
}
