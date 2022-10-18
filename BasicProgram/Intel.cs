using System;
namespace MyProject.BasicProgram
{
    class Intel
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter MyAge ");
            int MyAge = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter FriendAge =");
            int FriendAge = int.Parse(Console.ReadLine());
            if (MyAge > FriendAge)
            {
                Console.WriteLine("Hi");
            }
            else if (MyAge < FriendAge)
            {
                Console.WriteLine("Good Morning");
            }
            else
            {
                Console.WriteLine("How are you");
            }
        }

    }
    class PercentageClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Marks for English = ");
            float English = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Marks for Maths = ");
            float Maths = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Marks for Science = ");
            float Science = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Marks for Hindi = ");
            float Hindi = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Marks for Marathi = ");
            float Marathi = float.Parse(Console.ReadLine());
            float total = (English+Maths+Science+Hindi+Marathi);
            float average = (total) / 5.0f;
            float Percentage = (total/500) * 100;
            {
                Console.WriteLine("Total = " +total);
                Console.WriteLine("Average = " + average);
                Console.WriteLine("Percentage = " + Percentage);
            }
            if (Percentage >= 70)
            {
                Console.WriteLine("Distiction");
            }
            else if (Percentage >= 60)
            {
                Console.WriteLine("First Class");
            }
            else if (Percentage >= 50)
            {
                Console.WriteLine("Second Class");
            }
            else if (Percentage >= 35)
            {
                Console.WriteLine("Pass Class");
            }
            else
            {
                Console.WriteLine("Fail");
            }

        }
    }
    class Divisible
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number = ");
            int x = int.Parse(Console.ReadLine());
            if ((x % 3 == 0) || (x % 9 == 0))
            {
                Console.WriteLine("Number is Divisible");
            }
            else
            {
                Console.WriteLine("Not Divisible");
            }

        }
    }
    class EvenOddDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number = ");
            int x = int.Parse(Console.ReadLine());
            string str = x % 2 == 0 ? "Even" : "Odd";
            {
                Console.WriteLine("x is " + str);
            }
        }
    }

        class Session
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter Number = ");
                int x = int.Parse(Console.ReadLine());
                string str = x == 0 ? "Zero" : x > 0 ? "Positive" : "Negative";
                {
                    Console.WriteLine("x is " + str);
                }
            }
        }
    }


