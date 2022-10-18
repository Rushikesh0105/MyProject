using System;
namespace MyProject.BasicProgram
{
    class WhileloopDemo
    {
            static void Main(string[] args)
            {
                int i = 60;
                while (i >= 25)
                {
                    Console.WriteLine(i);
                    i--;
                }
            }

        }
        class DisplayDemo
        {
            static void Main(string[] args)
            {
                int i = 35;
                while (i <= 75)
                {
                    Console.WriteLine(i);
                    i++;
                }
            }
        }
        class FactDemo
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter Number = ");
                int num = int.Parse(Console.ReadLine());
                int fact = 1;

                int i = 1;
                while (i <= num)
                {
                    fact = fact * i;
                    i++;
                }
                Console.WriteLine("Factorial of Number = " + fact);

            }
        }
        class PalindromeWhile
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter Number = ");
                int num = int.Parse(Console.ReadLine());
                int sum = 0;

                int temp = num;
                while (num > 0)
                {
                    int p = num % 10;
                    sum = sum * 10 + p;
                    num = num / 10;

                }
                Console.WriteLine(+sum);
                if (temp == sum)
                {
                    Console.WriteLine("Number is Palindrome");
                }
                else
                {
                    Console.WriteLine("Number is Not Palindrome");
                }
            }
        }
        class SpyWhile
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter Number = ");
                int num = int.Parse(Console.ReadLine());

                int sum = 0;
                int mul = 1;
                while (num > 0)
                {
                    int p = num % 10;
                    sum = sum + p;
                    mul = mul * p;
                    num = num / 10;

                }
                Console.WriteLine(sum + " " + mul);
                if (sum == mul)
                {
                    Console.WriteLine("Number is Spy");
                }
                else
                {
                    Console.WriteLine("Number is Not Spy");
                }
            }
        }
    class EvenDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number = ");
            int num = int.Parse(Console.ReadLine());
            int digit = 1;
            int rem = 0;
            while(num>0)
            {
                digit = num % 10;
                num = num / 10;
                rem = digit % 2;

            }
            if(rem==0)
            {
                Console.WriteLine(+digit);
            }
        }
    }
    }
