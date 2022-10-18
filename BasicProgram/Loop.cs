using System;
namespace MyProject.BasicProgram
{
    class Print10
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)

            {

                Console.WriteLine(i);
            }
        }

    }
    class Reverse
    {
        static void Main(string[] args)
        {
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
    class Even
    {
        static void Main(string[] args)
        {

            for (int i = 2; i <= 20; i=i+2)
            {

                Console.WriteLine(i);
            }
        }
    }
    class Odd
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 20; i = i + 2)
            {

                Console.WriteLine(i);
            }
        }
    }
    class Power
    {
        static void Main(string[] args)
        {
            int power = 1;

            Console.WriteLine("Enter Base = ");
            int Base = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Exponent = ");
            int Exponent = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= Exponent; i++)
                power = power * Base;
            {
                Console.WriteLine("Power = " + power);
            }
        }
    }
    class Factorial
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number = ");
            int num = int.Parse(Console.ReadLine());
            int fact = 1;

            for (int i = 1; i <= num; i++)
            {
                fact = fact * i ;
                

            }
            Console.WriteLine("Factorial of A Number = " + fact);

        }
    }
    class SumForLoop
    {
         static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Enter the limit ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
                sum = sum + i;
            
                Console.WriteLine( "Sum of Given Number = "  +sum);
            

        }
    }
    class SumOfEven
    {
         static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Enter Number = ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 2; i <= num; i=i+2)
                sum = sum + i;
            {
                Console.WriteLine("Sum of Even Numbers Are = " +sum);
            }
        }
    }
    class OperatorMath
    {
        static void Main(String[] args)
        {
            int a = 5;int b = 4; int c = 3;
            Console.WriteLine(a++ + b * ++c);
            Console.WriteLine("a = " + a + " b= " + b + " c = " + c);
            Console.WriteLine(b * 5 / a + b++ + b);
            Console.WriteLine("a = " + a + " b= " + b + " c = " + c);
        }
    }
    class Pram
    {
        static void Main()
        {
            for (int n = 21; n<=35; n++)
            {
                if (n % 2 != 0)
                {
                    Console.WriteLine(n);


                }
            }
        }
    }


}




