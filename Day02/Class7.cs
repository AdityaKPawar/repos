using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercize
{
    internal class Que6
    {
        static void Main(string[] args)
        {
            /*8.WAP to catch multiple exceptions. i.e 
              IndexOutOfRangeException, NullReferenceException and DivideByZeroException. */


            int[] number = { 10, 20, 50, 40, 70 };
            int[] divisor = { 2, 0, 5, 0 };
            string name = null;

            for (int i = 0; i < number.Length; i++)
                try
                {
                    Console.WriteLine("Number is : " + number[i]);
                    Console.WriteLine("Divisor is : " + divisor[i]);
                    Console.WriteLine("Quoetient is : " + number[i] / divisor[i]);
                    string str = name.ToUpper();
                    Console.Write(str);
                }
                catch (NullReferenceException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }


            Console.ReadLine();


        }
    }
}