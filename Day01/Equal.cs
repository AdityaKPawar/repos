using System;

public class Equal
{
	public static void Main7()
	{
		int num1, num2;
		Console.WriteLine("Enter 1st number");
		num1 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter 2nd number");
		num2 = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Number is Equal Or not equal =  " + (num1 == num2));
	}
}
