using System;

public class Neasted5
{
	public static void Main4()
	{
		for (int loop1 = 1; loop1 <= 5; loop1++)
		{
			for (int loop2 = 1; loop2 <= loop1; loop2++)
			{
				Console.Write(loop1);
			}
			Console.Write("\n");
		}
	}
}
