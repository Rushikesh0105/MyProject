using System;
namespace MyProject.Loop
{
     class Looping
    {
         static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = int.Parse(Console.ReadLine());
            int digit;
            int sum = 0;
            int count = 0;

            while (num > 0)
            {
                digit = num % 10;
                sum = sum + digit;
                num = num / 10;
                ++count;
            }

            Console.WriteLine(sum+ " " +count);
            Console.WriteLine(sum/count);
             
        }
    }
    class Table
    {
         static void Main(string[] args)
        {
            Console.WriteLine("Enter Number = ");
            int num = int.Parse(Console.ReadLine());

            for(int i = 1; i <=10; i++)
            {
                Console.WriteLine(num*i);
            }
        }
    }  
          class ReverseExample
    {
         static void Main(string[] args)
        {
            int n, reverse = 0, rem;
            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n /= 10;
            }
            Console.Write("Reversed Number: " + reverse);
        }
    }
}
