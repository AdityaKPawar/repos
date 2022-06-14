using System;

public class Class1
{
	public static void Main3()
	{
		int num1, num2;

		Console.WriteLine("Enter any number1");
		num1 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter any number2");
		num2 = Convert.ToInt32(Console.ReadLine());

		if (num1 == num2)
		{
			Console.WriteLine("number1 is same as number2");
		}
		else
		{
			Console.WriteLine(" number1 different from number2");
		}
	}
}