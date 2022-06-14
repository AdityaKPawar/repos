using System;
public class SmOfSeries
{
	public static void Main12()
	{
		int n, i, series = 9;
		int sum = 0;
		Console.Write("Input the number or terms :");
		n = Convert.ToInt32(Console.ReadLine());
		for (i = 1; i <= n; i++)
		{
			sum = sum + series;
			Console.Write("{0}   ", series);
			series = series * 10 + 9;
		}
		Console.Write("\nThe sum of the saries = {0} \n", sum);
	}
}