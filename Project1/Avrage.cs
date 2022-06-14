using System;

public class avrage
{
	public static void Main5()
	{
		int num1, num2, num3, num4;
		Console.WriteLine("enter 1st number");
		num1 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("enter 2nd number");
		num2 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("enter 3rd number");
		num3 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("enter 4rth number");
		num4 = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("the avrage =  " + ((num1 + num2 + num3 + num4) / 4));
	}
}