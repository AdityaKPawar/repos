using System;

public class Class
{
	public static void Main3()
	{
		Console.WriteLine("Start main method");
		sum();
		substract();
		division();
		multiplication();
		Console.WriteLine("End main method");
	}
	public static void sum()
	{
		Console.WriteLine(5 + 5);
	}
	public static void substract()
	{
		Console.WriteLine(6 - 4);
	}
	public static void division()
	{
		Console.WriteLine(8 / 2);
	}
	public static void multiplication()
	{
		Console.WriteLine(4 * 3);
	}
}