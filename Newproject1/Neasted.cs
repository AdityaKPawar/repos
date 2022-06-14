using System;

public class Neasting
{
	public static void Main15()
	{
		int mark1, mark2;
		Console.WriteLine("Enter mark1");
		mark1 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter mark2");
		mark2 = Convert.ToInt32(Console.ReadLine());

		if (mark1 >= 30)
		{
			if (mark2 >= 30)
			{
				Console.WriteLine("Pass");
			}
			else
				Console.WriteLine("Inner if - FAIL");
		}
		else
			Console.WriteLine("Outer if - FAIL");
	}
}
