using System;

public class Calculator
{
	public static void Main5()
	{
		int num1, num2;
		Console.WriteLine("Enter the first number");
		num1 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter the first number");
		num2 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("The sum is =" + (num1 + num2));

		Console.WriteLine("The sum is =" + (num1 * num2));

		Console.WriteLine("The sum is =" + (num1 - num2));

		Console.WriteLine("The quotient is =" + (num1 / num2));
		Console.WriteLine("The remander is =" + (num1 % num2));

	}


}
