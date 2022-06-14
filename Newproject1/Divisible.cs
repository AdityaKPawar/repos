using System;
public class divisible
{
    public static void Main7()
    {
        int num;
        Console.WriteLine("Enter the num");
        num = Convert.ToInt32(Console.ReadLine());


        if (num % 5 == 0 && num % 11 == 0)
        {
            Console.WriteLine("number is divisible by 5 & 11");

        }
        else
        {
            Console.WriteLine("number is Not divisible by 5 & 11");
        }
    }
}