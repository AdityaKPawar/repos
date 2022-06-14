using System;

public class Compaire3
{
	public static void Main7()
	{
		int num1, num2, num3;

		Console.WriteLine("Enter any number1");
		num1 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter any number2");
		num2 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter any number3");
		num3 = Convert.ToInt32(Console.ReadLine());

		if (num1 == num2 && num2 == num3)
		{
			Console.WriteLine("number1 , number2 & number3 are same");
		}
		else if (num1 == num2 && num2 != num3)
		{
			Console.WriteLine(" number1 is same as number2 but number3 is diiferent");
		}
		else if (num1 == num3 && num2 != num3)
		{
			Console.WriteLine(" number1 is same as number3 but number2 is diiferent");
		}
		else if (num3 == num2 && num1 != num3)
		{
			Console.WriteLine(" number2 is same as number3 but number1 is diiferent");
		}
		else
		{

			Console.WriteLine(" number1, number2 & number3 are different");
		}
	}
}