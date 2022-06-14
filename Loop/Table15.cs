using System;

public class Table15
{
	public static void Main6()
	{
		int n, i;
		Console.WriteLine("Enter a number");
		i = Convert.ToInt32(Console.ReadLine());
		for (n = 1; n <= 10; n++)
		{
			Console.WriteLine(n * i);
		}
	}
}
