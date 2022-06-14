using System;

public class Weekday
{
	public static void Main20()
	{
		string day; ;
		Console.WriteLine("Enter a day ");
		day = Console.ReadLine();

		if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
		{
			Console.WriteLine("Weekday");
		}
		else if (day == "saturday" || day == "sunday")
		{
			Console.WriteLine("Weekend day");
		}


	}
}
