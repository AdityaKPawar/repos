using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class B
{
	public static void Main1(string[] args)
	{
		Console.WriteLine("Enter your name");
		string nm = Console.ReadLine();
		Console.WriteLine("Enter your age");
		try
		{
			int age = int.Parse(Console.ReadLine());
			Console.WriteLine($"Name " + nm + "Age " + age);
			Console.WriteLine("Character at 5th position" + nm[4]);
			try
			{


				Console.WriteLine("Enter 2 number");
				int a = int.Parse(Console.ReadLine());
				int b = int.Parse(Console.ReadLine());
				Console.WriteLine("Division " + a / b);
			}
			catch (DivideByZeroException d)
			{
				Console.WriteLine(d.Message);
			}
		}
		catch (FormatException ex)
		{
			Console.WriteLine("Age should be number");
		}
		catch (IndexOutOfRangeException e)
		{
			Console.WriteLine(e.Message);
		}
		catch (SystemException e)
		{
			Console.WriteLine(e.Message);
		}


	}
}

public class C
{
	static void divide(int a, int b)
	{
		Console.WriteLine("Division " + a / b);

	}
	static void Main2(string[] args)
	{
		Console.WriteLine();
		try
		{
			divide(10, 0);

		}
		catch (DivideByZeroException e)
		{
			Console.WriteLine("in main exeption handeled");
			Console.WriteLine(e.Message);
		}
		Console.WriteLine("Main end");
	}
}

class E
{
	static int divide(int a, int b)
	{
		try
		{
			Console.WriteLine("In division=");
			return a / b;
		}
		catch (DivideByZeroException e)
		{
			Console.WriteLine(e.Message);

		}
		finally
		{
			Console.WriteLine("in finally");
		}
		return 0;
	}
	static void Main3(string[] args)
	{
		Console.WriteLine("Main start");
		int result = divide(10, 0);
		Console.WriteLine("answer " + result);
		Console.WriteLine("Msin End");

	}
}

class F
{
	static int c;
	static string nm;
	static void Main(string[] args)
	{
		Console.WriteLine(c);
		//Stud[] sarr = new Stud[100];
		//Console.WriteLine(sarr[0]);
	}
}
