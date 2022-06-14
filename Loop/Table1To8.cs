using System;

public class Table1to8
{
	public static void Main8()
	{
		int n;
		n = Convert.ToInt32(Console.ReadLine());

		for (int loop1 = 1; loop1 <= n; loop1++)
		{
			for (int loop2 = 1; loop2 <= 10; loop2++)
				Console.WriteLine(loop1 * loop2);
		}
	}
}
