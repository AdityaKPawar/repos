using System;

class Subject
{
	public static void Main16()
	{
		Console.WriteLine("Enter marks in Math");
		int math = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Enter marks in phy");
		int phy = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Enter marks in chem");
		int chem = Convert.ToInt32(Console.ReadLine());

		int Total = math + phy + chem;

		if (Total >= 180)
		{
			Console.WriteLine("You are eligible for admission");
		}
		else
		{
			Console.WriteLine("You are not eligible for admission");


		}

	}
}