using System;

public class Meter
{
	public static void Main2()
	{
		int num;
		Console.WriteLine("Enter value in feet");
		num = Convert.ToInt32(Console.ReadLine());


		Console.WriteLine("conversion of feet into meter =  " + (num / 3.281));
	}
}
