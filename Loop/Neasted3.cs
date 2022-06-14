using System;

public class Neasted3
{
	public static void Main1()
	{
		int num, i;
		for (num = 1; num < 5; num++)
		{
			for (i = 1; i <= num; i++)
			{
				Console.Write("*");
			}
			Console.Write("\n");
		}
	}
}
