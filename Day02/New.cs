using System;
class Arith
{
    static void Main1(string[] args)
    {
        Console.WriteLine("Enter 2nd Number");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter 3rd Number");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int different = 4;
        int nth = 7;
        int first = num1 - different;
        int AP = first + (nth - 1) * 4;
        Console.WriteLine(AP);
    }
}

public class class13
{
    static void reverse(string str)
    {
        if (str != "")
        {
            Console.Write(str[str.Length - 1]);
            reverse(str.Substring(0, str.Length - 1));
        }
    }
    static void Main1(string[] args)
    {
        reverse("Aditya");
    }
}

public class class14
{

    static void Main(string[] args)
    {
        int[] arr = { 1, 0, 0, 1, 0, 1, 1, 0, 0 };
        int ones = 0, zeros = 0;
        int max = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            zeros = 0;
            ones = 0;
            for (int j = i; j < arr.Length; j++)
            {
                if (arr[j] == 0)
                    zeros++;
                else
                    ones++;
                if (ones == zeros)
                {
                    if (max < (j - i + 1))
                        max = j - i + 1;
                }
            }

        }
        Console.WriteLine(max);
    }

}