using System;
namespace MyProject.BasicProgram
{
    class AssignmentTwo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number = ");
            int x = int.Parse(Console.ReadLine());
            if ((x % 5 == 0) || (x % 11 == 0))
            {
                Console.WriteLine("Number is Divisible by 5 and 11");
            }
            else
            {
                Console.WriteLine("Not Divisible by 5 and 11");
            }
        }

    }
    class MaxThree
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Three Number = ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            if (num1 >= num2 && num1 >= num3)
            {
                Console.WriteLine("Number One Is Max ");
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                Console.WriteLine("Number Two Is Max ");
            }
            else
            {
                Console.WriteLine("Number Three Is Max ");
            }
        }
    }
    class Vowel
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Char = ");
            char ch = Convert.ToChar(Console.ReadLine());
            if ((ch == 'a') || (ch == 'e') || (ch == 'i') || (ch == 'o') || (ch == 'u') ||
               (ch == 'A') || (ch == 'E') || (ch == 'I') || (ch == 'O') || (ch == 'U'))
            {
                Console.WriteLine("Char is Vowel");
            }
            else
            {
                Console.WriteLine("Char is Consonent");
            }
        }
    }
    class Calculator
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("1-Addition");
            Console.WriteLine("2-Subtraction");
            Console.WriteLine("3-Multiplication");
            Console.WriteLine("4-Division");
            Console.WriteLine("Enter Choice");
            int ch = int.Parse(Console.ReadLine());

            if (ch == 1)

            {
                Console.WriteLine("Enter First Number = ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Second Number = ");
                b = int.Parse(Console.ReadLine());



                Console.WriteLine("Addition = " + (a + b));

            }
            else if (ch == 2)
            {
                Console.WriteLine("Enter First Number = ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Second Number = ");
                b = int.Parse(Console.ReadLine());

                Console.WriteLine("Subtraction =" + (a - b));
            }
            else if (ch == 3)
            {
                Console.WriteLine("Enter First Number = ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Second Number = ");
                b = int.Parse(Console.ReadLine());

                Console.WriteLine("Multiplicatin = " + (a * b));
            }
            else if (ch == 4)
            {
                Console.WriteLine("Enter First Number = ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Second Number = ");
                b = int.Parse(Console.ReadLine());

                Console.WriteLine("Division = " + (a / b));
            }
            else
            {
                Console.WriteLine("Invalid Choice");
            }
        }
    }
    class CheckNum
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Character = ");
            char ch = char.Parse(Console.ReadLine());
            if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'z'))
            {
                Console.WriteLine("Character is Alphabet");
            }
            else if (ch >= '0' && ch <= '9')
            {
                Console.WriteLine("Character is Digit ");
            }
            else
            {
                Console.WriteLine("Character is Special Character ");
            }
        }
    }
    class Zero
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number =");
            int num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("Number is Positive ");
            }
            else if (num < 0)
            {
                Console.WriteLine("Number is Negative");
            }
            else
            {
                Console.WriteLine("Number is Zero ");
            }
        }
    }
    class Conditional
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number = ");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }
        }
    }
    class EquilateralTriangleDemo
    {
        static void Main(String[] args)
        {
            
            Console.WriteLine("Enter side = ");
            float Side = float.Parse(Console.ReadLine());
            
           double Area = (1.73 * Side * Side) / 4;
            Console.WriteLine("Area Of Equilateral Triangle = " + Area);
        }
    }
    class Year
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Year : ");
            int Year = int.Parse(Console.ReadLine());
            if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
            {
                Console.WriteLine(" Leap Year." +Year);
            }
            else
            {
                Console.WriteLine("{0} is not a Leap Year.", Year);
            }
        }
    }
}  

    

