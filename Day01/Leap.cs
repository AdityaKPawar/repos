using System;

class Leap
{
	public static void Main10()
	{
		int year;
		Console.Write("Enter the year ");
		year = Convert.ToInt32(Console.ReadLine());
		if (year % 4 == 0)
		{
			Console.WriteLine("The year is leap");

		}
		else
		{
			Console.WriteLine("The year is not leap");
		}
	}
}
