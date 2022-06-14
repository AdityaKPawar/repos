using System;

public class OddEven2
{
	public static void Main4()
	{
		int num1;
		Console.WriteLine("Enter any number");
		num1 = Convert.ToInt32(Console.ReadLine());

		if (num1 % 2 == 0)
		{
			Console.WriteLine(num1 + "is even");
		}
		else
		{
			Console.WriteLine(num1 + " is odd");
		}
	}
}
