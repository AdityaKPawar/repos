using System;

public class NotEqual
{
	public static void Main15()
	{
		int num;
		Console.WriteLine("Enter any number");
		num = Convert.ToInt32(Console.ReadLine());

		String result = (!(num == 5)) ? "Yes" : "No";
		Console.WriteLine(result);

	}

}
