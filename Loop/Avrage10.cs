using System;

public class Avrage10
{
	public static void Main5()
	{
		int i, n, sum = 0;
		double avg;



		Console.Write("Input the 10 numbers : \n");
		for (i = 1; i <= 10; i++)
		{
			Console.Write("Number is {0} :", i);

			n = Convert.ToInt32(Console.ReadLine());
			sum = sum + n;
		}
		avg = sum / 10.0;
		Console.Write("The sum{0} & avrage is{1} ", sum, avg);

	}
}
