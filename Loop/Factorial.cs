using System;

public class Factorial
{
	public static void Main8()
	{
		int n, i, fact = 1;
		n = Convert.ToInt32(Console.ReadLine());
		for (i = 1; i <= n; i++)
		{
			fact = (fact * i);
			Console.WriteLine("factorial {0} = {1}", i, fact);
		}
	}
}
