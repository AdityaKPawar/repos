using System;

public class Element
{
	public static void Main5()
	{
		int num1, num2, num3, num4, num5;
		Console.WriteLine("Enter Five numbers ");
		num1 = Convert.ToInt32(Console.ReadLine());
		num2 = Convert.ToInt32(Console.ReadLine());
		num3 = Convert.ToInt32(Console.ReadLine());
		num4 = Convert.ToInt32(Console.ReadLine());
		num5 = Convert.ToInt32(Console.ReadLine());

		int Result = num1 + num2 + num3 + num4 + num5;
		Console.WriteLine("The sum of two number is = " + Result);
	}
}