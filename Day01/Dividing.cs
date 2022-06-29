using System;

public class Dividing
{
	public static void Main6()
	{
		int num1, num2;
		Console.WriteLine("Enter 1st number");
		num1 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter 2nd number");
		num2 = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("quotient = " + num1 / num2);
		Console.WriteLine("Reminder = " + num2 % num1);
	}

}
