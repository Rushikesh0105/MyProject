using System;
namespace MyProject.BasicProgram
{
    class Addition
    {
        static void Main(string[] args)
        {
            int a, b, result;
            a = 7;
            b = 8;
            result = (a + b);


            Console.WriteLine("Addition = " +result);
        }
    }
    class Subtraction
    {
        static void Main(string[] args)
        {
            int a, b, Sub;
            a = 12;
            b = 5;
            Sub = (a - b);
            Console.WriteLine("Subtraction =" +Sub);

        }
    }
    class Multiplication
    {
        static void Main(string[] args)
        {


            int x = 3;
            int y = 4;
            int mul = (x * y);
            Console.WriteLine("Multiplication = " +mul);
        }


    }
    class Division
    {
         static void Main(string[] args)
        {
            int a, b, div;
            a = 4;
            b = 2;
            div = (a / b);
            Console.WriteLine("Division = " +div);
        }
    }
    class Cube
    {
         static void Main(string[] args)
        {
            int i, result;
            i = 4;
            result = (i * i * i);
          
            Console.WriteLine("Cube = " +result);
        }
    }
    class Swapping
    {
         static void Main(string[] args)
        {
            int a, b, swap;
            a = 2;
            b = 4;
            swap = a;
            a = b;
            b = swap;
           
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
    class Arithmaticoperator
    {
         static void Main(string[] args)
        {
            int a, b;
            a = 8;
            b = 2;
            Console.WriteLine("Addition = " +(a+b));
            Console.WriteLine("Subtraction = " +(a-b));
            Console.WriteLine("Division = " +(a/b));
            Console.WriteLine("Multiplication = " +(a*b));
            Console.WriteLine("Modulus = " +(a%b));
        }
    }

}

       
    


