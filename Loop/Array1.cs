using System;

public class Array
{
    public static void Main11()
    {
        int[,] arr = new int[2, 2];


        for (int row = 0; row < 2; row++)
        {
            for (int col = 0; col < 2; col++)
            {
                arr[row, col] = Convert.ToInt32(Console.ReadLine());
            }
        }


        for (int row = 0; row < 2; row++)
        {
            for (int col = 0; col < 2; col++)
            {
                //if(row==0&& col)
                if (col == 0)
                    Console.WriteLine(arr[row, col]);
            }
        }
    }
}
