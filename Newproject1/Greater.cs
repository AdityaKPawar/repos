using System;

public class Greater
{
	public static void Main14()
	{
		int num1, num2, num3;
		Console.WriteLine("Enter three number");
		num1 = Convert.ToInt32(Console.ReadLine());
		num2 = Convert.ToInt32(Console.ReadLine());
		num3 = Convert.ToInt32(Console.ReadLine());

		if (num1 > num2)

			if (num1 > num3)
				Console.WriteLine("num1 is greater");
			else if (num3 > num2)
				Console.WriteLine("num3 is greater");
			else
				Console.WriteLine("num2 is greater");



	}
}
