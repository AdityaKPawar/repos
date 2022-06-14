using System;

public class Evensum
{
    public static void Main11()
    {
        int i, n, sum = 0;
        Console.Write("Input number of terms : ");
        n = Convert.ToInt32(Console.ReadLine());
        Console.Write("\nThe Even numbers are :");
        for (i = 1; i <= n; i++)
        {
            Console.Write("{0} ", 2 * i);
            sum = sum + 2 * i;
        }
        Console.Write("\nThe Sum of Even Natural Number upto {0} terms : {1} \n", n, sum);
    }
}

