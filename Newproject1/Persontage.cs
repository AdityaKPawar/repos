using System;

public class Persontage
{
	public static void Main10()
	{
		int m;
		Console.WriteLine("Enter Marks");
		m = Convert.ToInt32(Console.ReadLine());

		if (m > 90)
		{
			Console.WriteLine(" A grade");
		}
		else if (m > 80 && m < 90)
		{

			Console.WriteLine(" B grade");
		}
		else if (m >= 60 && m <= 80)
		{
			Console.WriteLine(" C grade");
		}
		else if (m < 60)
		{
			Console.WriteLine("D grade");
		}

	}
}
