using System;
namespace MyProject.BasicProgram
{
    
    class PositiveNegative
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number = ");
            int num = int.Parse(Console.ReadLine());
            if (num >= 0)
            {
                Console.WriteLine("Number is Positive ");
            }
            else
            {
                Console.WriteLine("Number is Negative ");
            }
        }
    }
    
}

