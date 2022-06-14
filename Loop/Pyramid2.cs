using System;

public class Class4
{
    public static void Main1()
    {

        for (int i = 1; i < 5; i++)
        {
            for (int k = 1; k < 9; k++)
            {
                if (k + i < 5 || k - i > 3)
                    Console.Write(" ");
                else
                    Console.Write(i);

            }
            Console.WriteLine();
        }
    }
}
