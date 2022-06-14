using System;

public class Digit
{
	public static void Main8()
	{
		int num1;

		Console.WriteLine("Enter any number");
		num1 = Convert.ToInt32(Console.ReadLine());

		if (num1 >= 10 || num1 <= -10)
		{
			Console.WriteLine("number is two digit");
		}
		else
		{
			Console.WriteLine("number is single digit");
		}
	}
}