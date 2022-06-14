using System;

public class Class3
{
	public static void Main1(string[] args)
	{

		int a = 18;
		int b = 12;

		int c = 0;
		for (int divider = 1; divider <= a && divider <= b; divider++)
		{
			if (a % divider == 0 && b % divider == 0)
			{
				c++;
			}
		}
		if (c == 1)
			Console.WriteLine("Co prime");
	}
}

class Class16
{
	static void Main2(string[] args)
	{
		int a2 = Convert.ToInt32(Console.ReadLine());
		int a3 = Convert.ToInt32(Console.ReadLine());
		int n = Convert.ToInt32(Console.ReadLine());
		int diff = a3 - a2;
		for (int i = 2; i < n; i++)
		{
			a3 = a3 + diff;

		}
		Console.WriteLine(a3);
	}
}