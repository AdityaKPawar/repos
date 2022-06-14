using System;
public class Anagram
{
	public static void Main1(string[] args)
	{
		Console.WriteLine("Enter a string");
		string str1 = Console.ReadLine();
		Console.WriteLine("Enter a string");
		string str2 = Console.ReadLine();

		string s1 = str1.ToLower();
		string s2 = str2.ToLower();

		char[] ch1 = s1.ToCharArray();
		char[] ch2 = s2.ToCharArray();

		//Array.Sort(ch1);
		//Array.Sort(ch2);

		//Console.WriteLine(String.Join(" ", ch1));

		//String st1 = new String(ch1);

	}

}


