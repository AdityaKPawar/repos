using System;

public class Addition
{
	public static void Main3()
	{
		int num1, num2;
		Console.WriteLine("Enter Two numbers ");
		num1 = Convert.ToInt32(Console.ReadLine());
		num2 = Convert.ToInt32(Console.ReadLine());

		int Result = num1 + num2;
		Console.WriteLine("The sum of two number is = " + Result);
	}
}