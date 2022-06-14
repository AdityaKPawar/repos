using System;

public class Class20
{
	public string number;
	void display(int a)
	{
		Console.WriteLine(2 * 5);
	}
	void display(int a, int b)
	{
		Console.WriteLine("first" + 1 + "second" + 2);
	}

	public static void Main2(string[] args)
	{
		Class20 obj = new Class20();
		obj.display(1);
		obj.display(1, 2);
		Console.ReadLine();
	}

}
class class21 : Class20
{
	public void Aditya()
	{
		Console.WriteLine(number);
	}
}

class program
{
	public static void Main1(string[] args)
	{
		Class20 obj1 = new Class20();

	}
}