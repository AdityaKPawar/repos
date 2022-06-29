
using System;



class Vowel
{
	public static void Main18()
	{
		Console.WriteLine("Enter the alphabet");
		char ch = Convert.ToChar(Console.ReadLine());

		if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
		{
			Console.WriteLine("Apbhabet is vowel");

		}
		else
		{

			Console.WriteLine("Apbhabet is consonants");

		}
	}
}
