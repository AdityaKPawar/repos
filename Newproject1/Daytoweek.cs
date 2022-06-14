using System;

public class Class1
{
	public static void Main5()
	{
		int d;
		Console.WriteLine("Enter Days ");
		d = Convert.ToInt32(Console.ReadLine());


		Console.WriteLine("Week =  " + (d / 7));
		Console.WriteLine("Month =  " + (d / 12));
		Console.WriteLine("Year =  " + (d / 365));

	}
}
