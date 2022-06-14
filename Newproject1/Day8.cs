using System;

public class Day8
{
    public static void Main17()
    {
        int num1, num2 = 0, num3 = 0, output = 0;
        Console.WriteLine("Enter any number");
        num1 = Convert.ToInt32(Console.ReadLine()); //5
        num1--;  //4
        Console.WriteLine("num1 = {0} num2 = {1} num3 = {2} output = {3}", num1, num2, num3, output);
        output = 40; //output=40
        num2 = output; //num2=40
        output = num2--;
        //num2=39, output=  40, num1=4,num3=0
        Console.WriteLine("num1 = {0} num2 = {1} num3 = {2} output = {3}", num1, num2, num3, output);
        num3 = num2 + num1;  //num2=39, output=40 , num1=4,num3=43
        num3--; //num3=42
        output = --num3;
        // output=41, num3=41
        Console.WriteLine("num1 = {0} num2 = {1} num3 = {2} output = {3}", num1, num2, num3, output);
    }

}
