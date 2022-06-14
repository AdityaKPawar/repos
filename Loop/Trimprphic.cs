using System;

public class trimorphic
{
	public static void Main1()
	{

		int number, rev;
		Console.WriteLine("Enter any number");
		number = Convert.ToInt32(Console.ReadLine());


		rev = number * number * number;
		rev = rev % 10;
		if (rev == number)
		{
			Console.WriteLine("trimorfic");

		}
		else
			Console.WriteLine("not trimorfic");
	}

}

