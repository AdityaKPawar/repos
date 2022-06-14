using System;

public class Siblings
{
	public static void Main1()
	{
		int num1, num2;

		Console.WriteLine("Enter older siblings");
		num1 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter younger sibiling");
		num2 = Convert.ToInt32(Console.ReadLine());

		if (num1 == 0 && num2 == 0)
		{
			Console.WriteLine("Only Child");
		}
		else if (num1 == 0 && num2 > 0)
		{
			Console.WriteLine("Older child");
		}
		else if (num1 > 0 && num2 == 0)
		{
			Console.WriteLine(" Younger child");
		}
		else if (num1 == num2)
		{
			Console.WriteLine(" Middle child");
		}
	}
}
