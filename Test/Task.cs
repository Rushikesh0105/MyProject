using System;
namespace MyProject.Test
{
    class Task
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number =");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int expo = 0;
            int Base = 1;
            int temp = num;

            while (num > 0)
            {
                int p = num % 10;
                Base = p;
                num = num / 10;
                expo++;

            }
            Console.WriteLine(expo);
            num = temp;

            while (num > 0)
            {
                int power = 1;
                int r = num % 10;
                for (int i = 1; i <= expo; i++)
                {
                    power = power * r;
                }
                sum = sum + power;
                expo--;
                num = num / 10;

            }
            Console.WriteLine(sum);
            if (temp == sum)
            {
                Console.WriteLine("Disarium");
            }
            else
            {
                Console.WriteLine("Not Disarium");
            }



        }
    }
    class Automorphic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number =");
            int num = int.Parse(Console.ReadLine());
            int square = 1;
            int count = 0;
            int temp = num;

            while (num > 0)
            {
                int digit = num % 10;
                count++;
                num = num / 10;
            }
            //Console.WriteLine(count);

            num = temp;

            int power = 1;
            int Base = 10;
            square = num * num;

            for (int i = 1; i <= count; i++)
            {

                power = power * Base;
            }
            Console.WriteLine(square);
            // Console.WriteLine(power);
            int last = square % power;



            if (num == last)
            {
                Console.WriteLine("AutoMorphic");
            }
            else
            {
                Console.WriteLine("Not Automorphic");
            }



            // Console.WriteLine(square);



        }
    }
    class oneseries
    {
        static void Main(String[] args)
        {
            int s = 0;
            for (int i = 0; i <= 7; i++)
            {
                s = s * 10 + 1;
                int n = s + 10;
                Console.Write(" ");
                Console.Write(s);
            }
            Console.Write("");
        }
    }

    class Fibonacciseries
    {
        static void Main(String[] args)
        {
            int f = 0, f1 = 1, f2 = 0, n = 10;
            Console.WriteLine("Enter the terms of series=");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fibonaccie Series=");
            for (int i = 0; i <= n; i++)
            {
                f = f1 + f2;
                f1 = f2;
                f2 = f;
                Console.WriteLine(f + " ");
            }
        }
    }

    class DisplayColor
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter a Number=");
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                if (n >= 2 && n <= 8)
                {
                    Console.WriteLine("Green");
                }
                else
                {
                    Console.WriteLine("Red");
                }
            }
            else
            {
                if (n > 8)
                {
                    Console.WriteLine("White");
                }
                else
                {
                    Console.WriteLine("Black");
                }
            }
        }
    }
   
}

