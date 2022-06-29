using System;

public class FirstDivisible
{
	public static void Main9()
	{
		int num1, num2;
		Console.WriteLine("Enter 1st number");
		num1 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter 2nd number");
		num2 = Convert.ToInt32(Console.ReadLine());

		if (num1 % num2 == 0)
		{
			Console.WriteLine("number 1 is divisible by number 2");
		}
		else
		{
			Console.WriteLine("number 1 is not divisible by number 2");
		}
	}
}
