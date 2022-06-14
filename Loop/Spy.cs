using System;

public class Spy
{
	public static void Main2()
	{
		int number, sum = 0, rem, rev = 1;
		Console.WriteLine("Enter any number");
		number = Convert.ToInt32(Console.ReadLine());
		while (number > 0)
		{
			rem = number % 10;
			sum = sum + rem;
			rev = rev * rem;
			number = number / 10;
		}
		if (sum == rev)
		{
			Console.WriteLine("Spy number");

		}
		else
			Console.WriteLine("not spy");
	}
}
