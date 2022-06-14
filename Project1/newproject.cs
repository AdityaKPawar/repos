using System;


namespace Day1
{

    class Day
    {

        public static void Main12()
        {



            Console.WriteLine("Main method starts");


            Day callprint = new Day();

            callprint.print();
            readMethod();


            Shapes square = new Shapes();
            square.quad_Area();

            square.square_Perimeter();
            Console.WriteLine("Main method end");
        }


        public void print()
        {
            Console.WriteLine("this is a non static Print Method");
        }

        public static void readMethod()
        {
            Console.WriteLine("this is a static Read Method");
        }
    }

    class Shapes
    {

        int area, length = 10, breadth = 12, perimeter;

        public void quad_Area()
        {

            area = length * breadth;


        }
        public void square_Perimeter()
        {

            perimeter = length + breadth;
            Console.WriteLine("Perimeter of a Square is " + perimeter);
            Print(perimeter);
        }
        public static void Print(int result)
        {
            Console.WriteLine("print method of Shapes class " + result);
            Day day10 = new Day();
            day10.print();
            Day.readMethod();
        }
    }

}