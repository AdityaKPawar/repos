using System;

public class NeastedB
{
    public static void Main60()
    {
        for (int row = 1; row <= 7; row++)
        {
            if (row == 1 || row == 7)
            {
                Console.WriteLine(" *** ");
                continue;
            }
            if (row == 4)
            {
                Console.WriteLine(" **** ");
            }



            for (int col = 1; col <= 5; col++)
            {
                if (col == 1 || col == 5)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.Write("\n");
        }
    }

}


