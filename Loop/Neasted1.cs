using System;

public class Neasted
{
	public static void Main1()
	{

		for (int raw = 1; raw <= 5; raw++)
		{
			for (int col = 1; col <= raw; col++)
			{
				Console.Write("*");
			}
			Console.WriteLine("");
		}
	}
}
