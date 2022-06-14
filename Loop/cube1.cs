using System;

public class Cube
{
	public static void Main4()
	{
		int n, i;
		Console.WriteLine("Enter a number");
		i = Convert.ToInt32(Console.ReadLine());


		for (n = 1; n <= i; n++)
		{
			Console.WriteLine("Cube is  " + (i * i * i));
		}


	}
}
