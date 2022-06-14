using System;

public class String2
{
	static void Main1(string[] args)
	{
		Console.WriteLine("Enter Password");
		string s1 = Console.ReadLine();

		bool IsValid = true;
		for (int i = 0; i < s1.Length; i++)
		{
			if (char.ToUpper(s1[i]) == (s1[i]))

			{
				Console.Write("Count" + i);
			}
			else if (char.ToUpper(s1[i]) != (s1[i]))
				Console.Write(s1[i]);

		}


	}
}
