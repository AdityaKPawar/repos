using System;

public class Max
{
	public static void Main11()
	{
		int num1, num2;
		Console.WriteLine("Enter 1st number");
		num1 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter 2nd number");
		num2 = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Number is greater than =  " + (num1 > num2));
		Console.WriteLine(" Number is smaller than =  " + (num1 < num2));
	}
}