using System;


namespace Training_BasicDemo_Day1
{
    class Day16_pattern
    {
        public static void Main58()
        {

            for (int row = 1; row <= 8; row++)
            {
                if (row == 1)
                {
                    Console.WriteLine(" *** ");
                    continue;
                }
                if (row == 4)

                {
                    Console.WriteLine("*****");
                    continue;
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
}
