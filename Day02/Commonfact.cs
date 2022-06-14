using System;

public class Class4
{
	public static void Main1(string[] args)
	{
		int a = 18;
		int b = 12;

		for (int divider = 1; divider < a; divider++)
		{
			if (a % divider == 0 && b % divider == 0)
				Console.WriteLine(divider);
		}
	}
}

namespace first
{
	public class Emp
	{
		public virtual void firstmethode()
		{
			Console.WriteLine("Employee");
		}
	}
	public class Manager : Emp
	{
		public override void firstmethode()
		{
			Console.WriteLine("Manager");
		}

	}
	class program
	{
		public static void Main1(string[] args)
		{
			Manager M1 = new Manager();
			M1.firstmethode();
			Emp E1 = new Emp();
			E1.firstmethode();
			Emp E2 = new Manager();
			E2.firstmethode();


		}
	}
}