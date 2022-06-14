using System;

public class Pyramid
{
	public static void Main11()
	{
		int rows = 5;

		for (int i = 1; i <= rows; i++)
		{
			for (int k = rows - i; k >= 1; k--)
			{
				Console.Write(" ");
			}
			for (int j = 1; j <= i; j++)
			{
				Console.Write("*");
			}
			Console.Write("\n");
		}
	}
}
