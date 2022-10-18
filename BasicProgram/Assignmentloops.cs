using System;
namespace MyProject.BasicProgram
{
    class Assignmentloops
    {
        static void Main(string[] args)
        {
            for (int i = 175; i >= 120; i--)
                Console.WriteLine(i);

        }
    }

    class EvenAlternateLoop
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 20; i = i + 4)
                Console.WriteLine(i);
        }
    }
    class OddCount
    {


        static void Main(String[] args)
        {
            int i = 0;

            Console.WriteLine("Odd Numbers :");
            for (i = 1; i <= 20; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
    class Seies2
    {
        static void Main(String[] args)  //1,8,27,64....
        {
            int n, i;
            Console.WriteLine("Enter the number");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                Console.WriteLine(i * i * i + "");
            }
        }
    }

    class Series3
    {
        static void Main(String[] args)   //0,7,26,63....
        {
            int n, i, p;
            Console.WriteLine("Enter the number");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                p = i * i * i - 1;
                Console.WriteLine(p);
            }
        }
    }

    class Seies4
    {
        static void Main(String[] args)  //1,4,9,16...
        {
            int n, i;
            Console.WriteLine("Enter the number");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                Console.WriteLine(i * i + "");
            }
        }
    }
}
