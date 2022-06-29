using System;

public class Positive
{
	public static void Main13()
	{
		int num1;
		Console.WriteLine("Enter any number");
		num1 = Convert.ToInt32(Console.ReadLine());

		if (num1 > 0)
		{
			Console.WriteLine(num1 + "  is Positive");
		}
		else if (num1 < 0)
		{
			Console.WriteLine(num1 + "   is Negative");
		}
		else
		{
			Console.WriteLine(num1 + "  is zero");
		}
	}
}
