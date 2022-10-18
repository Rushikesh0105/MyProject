using System;
namespace MyProject.BasicProgram
{
    class Assignment
    {
        static void Main(string[] args)
        {
            int a, b, sum;
            a = 12;
            b = 4;
            sum = (a + b);
            Console.WriteLine("Sum = " + sum);
        }

    }
    class ArithmaticOP
    {
        static void Main(string[] args)
        {
            int a, b;
            a = 4;
            b = 2;
            Console.WriteLine("Addition = " + (a + b));
            Console.WriteLine("Subtraction = " + (a - b));
            Console.WriteLine("Multiplication = " + (a * b));
            Console.WriteLine("Division = " + (a / b));
        }
    }
    class Rectangle
    {
        static void Main(string[] args)
        {
            int length, breadth, area;
            length = 4;
            breadth = 2;
            area = length * breadth;
            Console.WriteLine("Area Of Rectangle = " + area);

        }
    }
    class Triangle
    {
        static void Main(string[] args)
        {
            int length, breadth, area;
            length = 6;
            breadth = 4;
            area = length * breadth;
            Console.WriteLine("Area Of Triangle = " + area);
        }
    }

    class Square
    {
        static void Main(string[] args)
        {
            int a, square;
            a = 4;
            square = (a * a);
            Console.WriteLine("Square = " + square);
        }
    }
    class cube
    {
        static void Main(string[] args)
        {
            int a, cube;
            a = 3;
            cube = (a * a * a);
            Console.WriteLine("Cube = " + cube);
        }
    }
    class Meter
    {
        static void Main(string[] args)
        {

            double cm, meter, km;
            cm = 1000;
            meter = cm / 100;
            km = cm / 100000;
            Console.WriteLine("Enter Length in Centimeter = " + cm);
            Console.WriteLine("Length in Meter=" + meter);
            Console.WriteLine("Length in Kilometer=" + km);
        }
    }
    class Percentage
    {
        static void Main(string[] args)
        {
            float English, Maths, Science, Marathi, Hindi, Total;
            English = 80;
            Maths = 80;
            Science = 80;
            Marathi = 80;
            Hindi = 80;
            Total = 500f;
            float percentage, average;
            average = (English + Maths + Science + Marathi + Hindi) / Total;
            percentage = average * 100;
            Console.WriteLine("Percentage = " + percentage);
        }
    }
    class SimpleInterest
    {
        static void Main(string[] args)
        {

            int P, T, R;
            double SI;
            P = 3400;
            T = 5;
            R = 5;
            Console.WriteLine("Enter Principal Amount=" + P);
            Console.WriteLine("Time=" + T);
            Console.WriteLine("Rate=" + R);
            SI = (P * T * R) / 100;
            Console.WriteLine("Simple Interest is " + SI);
        }
    }
    class PerimeterRectangle
    {

        static void Main(string[] args)
        {
            int Length = 20;
            int Breadth = 10;
            Console.WriteLine("Length of Rectriangle=" + Length);
            Console.WriteLine("Breadth Of Rectriangle=" + Breadth);
            int Perimeter = 2 * (Length + Breadth);
            Console.WriteLine("Perimeter Of Rectangle=" + Perimeter);
        }
    }

    class EquilateralTriangle
    {
        static void Main(String[] args)
        {
            float Side;
            double Area;
            Side = 20;
            Console.WriteLine("Enter a Side of Equilateral Triangle = " + Side);
            Area = (1.73 * Side * Side) / 4;
            Console.WriteLine("Area Of Equilateral Triangle = " + Area);
        }
    }
    class ComputeFormula
    {
        static void Main(string[] args)
        {
            Console.WriteLine(((25.5 * 3.5 - 3.5 * 3.5) / (40.5 - 4.5)));
        }
    }

    class SpecifiedFormula
    {
        static void Main(string[] args)
        {
            Console.WriteLine(4.0 * (1 - (1.0 / 3) + (1.0 / 5) - (1.0 / 7) + (1.0 / 9) - (1.0 / 11)));
        }
    }
    class Temprature
    {
        static void Main(string[] args)
        {
            float celsius, fahrenheit;
            celsius = 12f;
            fahrenheit = ((celsius * 9) / 5) + 32;
            Console.WriteLine("fahrenheit = " + fahrenheit);
        }
    }
    class Temprature2
    {
static void Main(string[] args)
        {
            float celsius, fahrenheit;
            fahrenheit = 54;
            celsius = ((fahrenheit - 32) * 5) / 9;
            Console.WriteLine("Celsius = " + celsius);
        }
    }
   
        class YearsDays
        {
            static void Main(String[] args)
            {
                int Days, Years, Weeks;
                int DaysInWeek = 7;
                Console.WriteLine("Enter the Number of Days=");
                Days = int.Parse(Console.ReadLine());
                Years = Days / 365;
                Weeks = (Days % 365) / DaysInWeek;
                Days = (Days % 365) % 7;
                Console.WriteLine("Year=" + Years);
                Console.WriteLine("Week=" + Weeks);
                Console.WriteLine("Days=" + Days);

            }
        }
    }






