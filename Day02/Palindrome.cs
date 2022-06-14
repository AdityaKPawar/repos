using System;
using System.Text;

public class Class5
{
	public static void Main1(string[] args)
	{
		string s = "nitiN";
		bool IsPalind = true;

		for (int start = 0, end = s.Length - 1; start < end; start++, end--)
		{
			if (s[start] != s[end])
			{
				IsPalind = false;
				break;
			}
			Console.WriteLine("Is palindrom");
		}
		Console.WriteLine("Is not palindrom");

	}
}


public class Class8
{
	public static void Main2(string[] args)
	{
		string s = "Aditya";
		string reverse = "";
		int count = 0;
		for (int i = s.Length - 1; i >= 0; i--)
		{
			reverse = reverse + s[i];
			count++;
		}
		Console.WriteLine(count);
		Console.WriteLine(reverse);
		if (reverse == s)
		{
			Console.WriteLine("Palindrome");
		}
		else
		{
			Console.WriteLine("Not Palindrom");
		}
	}
}

partial class Class9
{
	public static void Main1(string[] args)
	{
		StringBuilder sb = new StringBuilder(" Hello");
		sb.Append(" Aditya");
		sb.Append(" Pawar");
		Console.WriteLine(sb.ToString());
	}
}