using System;

public class Neasted4
{
	public static void Main2()
	{
		for (int loop1 = 1; loop1 <= 5; loop1++)
		{
			for (int loop2 = 1; loop2 <= loop1; loop2++)
			{
				Console.Write(loop2);
			}
			Console.Write("\n");
		}
	}
}
