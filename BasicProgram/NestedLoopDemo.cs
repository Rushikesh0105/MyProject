using System;
namespace MyProject.BasicProgram
{
    class NestedLoopDemo
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }

    }
    class NumberPatternDemo1
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
    class NumberPattern2
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
    class NumberPattern3
    {
        static void Main(string[] args)
        {
            for (int i = 4; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
    class NumberPattern4
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

    }
    class Age
    { 
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Age = ");
        int age = int.Parse(Console.ReadLine());

        if ((age >= 13) && (age <= 19))
        {
            Console.WriteLine("Teenager");
        }
        else
        {
            Console.WriteLine("Not Teenager");
        }
    }
}
    class Average
    {
         static void Main(string[] args)
        {
            int sum = 0;
            float average=1f;
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
                sum = sum + i;
                average = sum / 10;
            }
            Console.WriteLine("Sum = " +sum);
            Console.WriteLine( "Average = " +average);

        }
    }
}

