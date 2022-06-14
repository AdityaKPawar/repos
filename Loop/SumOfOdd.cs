using System;

public class SumOfOdd10
{
    public static void Main11()
    {
        int i, n, sum = 0;
        Console.Write("Input number of terms : ");
        n = Convert.ToInt32(Console.ReadLine());
        Console.Write("\nThe odd numbers are :");
        for (i = 1; i <= n; i++)
        {
            Console.Write("{0} ", 2 * i - 1);
            sum = sum + 2 * i - 1;
        }
        Console.Write("\nThe Sum of odd Natural Number upto {0} terms : {1} \n", n, sum);
    }
}
