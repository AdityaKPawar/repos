using System;

public class Class1
{
	public static void Main4()
	{

		sum1();
		sum2();
		sum3();
		sum4();
	}
	public static void sum1()
	{
		int num1 = 4;
		int num2 = 5;

		Console.WriteLine("The sum is =" + (num1 + num2));
	}
	public static void sum2()
	{
		float num1 = 4.2f;
		float num2 = 5.6f;

		Console.WriteLine("The sum is =" + (num1 + num2));
	}
	public static void sum3()
	{
		double num1 = 3.4;
		double num2 = 2.4;

		Console.WriteLine("The sum is =" + (num1 + num2));
	}
	public static void sum4()
	{
		string a1 = "aditya";
		string a2 = "pawar";

		Console.WriteLine("My name is " + (a1 + "  " + a2));
	}
}
