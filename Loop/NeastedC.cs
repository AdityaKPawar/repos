using System;

public class NeastedC
{
    public static void Main61()
    {
        for (int row = 1; row <= 7; row++)
        {
            if (row == 1 || row == 7)
            {
                Console.WriteLine(" *** ");
                continue;
            }
            if (row == 2 || row == 6)
            {
                Console.WriteLine("*   *");
                continue;
            }



            for (int col = 1; col <= 5; col++)
            {
                if (col == 1)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.Write("\n");
        }
    }
}
