using System;

public class PostIcreament
{
	public static void Main()
	{
		int number, result;
		Console.WriteLine("Enter a number");
		number = Convert.ToInt32(Console.ReadLine());

		//result = number++;
		//Console.WriteLine("Post Increament example \n number is{0} result is {1} " ,number, result);

		//result = ++number;
		result = number++;
		number = 8;
		result = number + result;


		Console.WriteLine("Pre Increament example \n number is{0} result is {1} ", number, result);
	}
}
