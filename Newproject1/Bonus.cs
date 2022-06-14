using System;

public class Bonus
{
	public static void Main13()
	{
		double s, y, b;
		Console.WriteLine("Enter Salary");
		s = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter Time period of service of Employee");
		y = Convert.ToInt32(Console.ReadLine());

		if (y > 10)
		{
			b = (s * 0.1) + s;
			Console.WriteLine("Net salary including bonus =" + b);
		}
		else if (y >= 6 && y <= 10)
		{
			b = (s * 0.08) + s;
			Console.WriteLine("Net salary including bonus =" + b);
		}
		else if (y < 6)
		{
			b = (s * 0.05) + s;
			Console.WriteLine("Net salary including bonus =" + b);
		}
	}
}

