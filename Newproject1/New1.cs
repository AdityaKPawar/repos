using System;

public class Attendence
{
	public static void Main12()
	{
		double a, b, p;
		Console.WriteLine("Enter the attended lecture");
		a = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter Out of lecture");
		b = Convert.ToInt32(Console.ReadLine());

		p = (a / b);

		if (p <= 0.75)
		{
			Console.WriteLine("Student will not able to Sit in Exam" + p);
		}
		else
		{
			Console.WriteLine("student is allowed to sit in exam");
		}

	}
}
