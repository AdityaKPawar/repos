using System;

public class Class2
{
	public static void Main1(string[] args)
	{
		Console.WriteLine("Enter String");
		string str = Console.ReadLine();
		Console.WriteLine("Enter String");
		string str1 = Console.ReadLine();


		String s1 = str.ToLower();
		String s2 = str1.ToLower();
		char[] chars = s1.ToCharArray();
		char[] chars1 = s2.ToCharArray();
		Array.Sort(chars);
		Array.Sort(chars1);

		Console.WriteLine(String.Join(" ", chars));
		Console.WriteLine(String.Join(" ", chars1));
		String str3 = new String(chars);
		String str4 = new String(chars1);

		if (str1.CompareTo(str3) == 0)
		{
			Console.WriteLine(" not Anagram");

		}
		Console.WriteLine("Ana");
	}
}
