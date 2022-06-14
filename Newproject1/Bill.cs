using System;

internal class Electricity
{
    public static void Main11()
    {
        int unit, a, b;
        Console.WriteLine("Input the unit consumed by the customer : ");
        unit = Convert.ToInt32(Console.ReadLine());
        if (unit < 100)
        {
            Console.WriteLine("No charge");
        }
        else if (unit >= 100 && unit < 200)
        {
            b = (unit - 100) * 5;
            Console.WriteLine("Bill is" + b);
        }
        if (unit >= 200)
        {



            Console.WriteLine("Bill is" + ((unit - 200) * 10 + 500));
        }

    }
}