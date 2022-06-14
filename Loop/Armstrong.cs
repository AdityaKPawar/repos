using System;
public class Exercise29
{
    public static void Main18()
    {
        int num, r, sum = 0, temp;
        Console.Write("Input  a number: ");
        num = Convert.ToInt32(Console.ReadLine());

        for (temp = num; num != 0; num = num / 10)
        {
            r = num % 10;
            sum = sum + (r * r * r);


        }
        if (sum == temp)
        {
            Console.WriteLine("arm");
        }
        else
            Console.WriteLine("no");
    }
}