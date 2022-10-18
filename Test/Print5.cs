using System;
namespace MyProject.Test
{
    class Print5
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if ((i % 5 != 0) || (i % 10 != 0))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
    class Toop
    {
        static void Main(String[] args)
        {
            int b = 0;
            do
            {
                int a = 2;
                b++;

                Console.WriteLine(a++);
            }
            while (b != 3);
        }
    }
    class Problem3
    {
        static void Main(string[] args)
        {
            int i = 1;
            int k = 1;
            while (i++ <= 5)
            {
                k *= i;
            }
            Console.WriteLine("k = " + k + "i = " + i);
        }
    }
    class SpyNo4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number = ");
            int num = int.Parse(Console.ReadLine());

            int sum = 0;
            int mul = 1;

            while (num > 0)
            {
                int digit = num % 10;
                sum = sum + digit;
                mul = mul * digit;
                num = num / 10;
            }
            Console.WriteLine(sum + " " + mul);
            if (sum == mul)
            {
                Console.WriteLine("Spy Number");
            }
            else
            {
                Console.WriteLine("Not Spy Number");
            }
        }
    }
    class Trimorphic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number = ");
            int num = int.Parse(Console.ReadLine());

            int temp = num;


            int c = num * num * num;
            int rem = c % 10;


            if (temp == rem)
            {
                Console.WriteLine("Trimorphic");
            }
            else
            {
                Console.WriteLine("Not Trimorphic");
            }
        }

    }
    class Problem9
    {
        static void Main(string[] args)
        {
            for (int i = 5; i > 0; i--)
            {
                int mysteryInt = 100;
                mysteryInt = mysteryInt-i;
                Console.WriteLine(mysteryInt);
            }
        }
    }
    class Problem10Prime
    {
         static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            Console.WriteLine("Enter two Numbers = ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            for(int i = 1; i <= num1; i++)
            {
                if (num1 % i == 0)
                {
                    a++;
                }
            }
            for(int j = 1; j <= num2; j++)
            {
                if (num2 % j == 0)
                {
                    b++;
                }
            }
            c = num1 - num2;
            Console.WriteLine(c);
            if (c ==2 && num2 == 2 && num1 == 2)
            {
                Console.WriteLine("Twin prime");
            }
            else
            {
                Console.WriteLine("Not Twin prime");
            }



        }
    }



    class Integer
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter no");
            int n = int.Parse(Console.ReadLine());

            if (n % 2 != 0)
            {
                Console.WriteLine("Weird");
            }
            else if((n%2==0) && (n>=2) && (n<=5) )
                {
                Console.WriteLine("Not wierd");
            }
            else if((n%2==0) && (n>=6) && (n<=20))
            {
                Console.WriteLine("Weird");
            }
            else if((n%2==0) && (n > 20))
            {
                Console.WriteLine("Not Weird");
            }
            else
            {
                Console.WriteLine("Not Weird");
            }
        }
    }
    class EvenProblem12
    {
         static void Main(string[] args)
        {
            int square;
            for(int i=1;i<=50;i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                 if(i%2!=0)
                {
                    square = -i * i;
                    Console.WriteLine(-i+ " = "+square);
                }
            }
        }
    }
    class Problem13
    {
         static void Main(string[] args)
        {
            int i = 1;
            while (i <= 5)
            {
                int j = 1;
                while (j <= 5)
                {
                    if (j == 2)
                    {

                        break;

                    }
                    Console.WriteLine(j);


                    j++;
                }
                Console.WriteLine(i);
            }

        }
    }
    class Problem11
    {
         static void Main(string[] args)
        {
           // Console.WriteLine("Enter Number");
            //int num = int.Parse(Console.ReadLine());
            for(int i=1;i<=10;i++)
            {
               int num = (i * i) + (i * i * i);
                Console.Write(num+" ");
            }
        }
    }
    class FibbonaciSeries
    {
         static void Main(string[] args)
        {
            Console.WriteLine("Enter Term = ");
            int num = int.Parse(Console.ReadLine());

            int f1= 0;
            int f2 = 1;
            int f;
            Console.Write(f1+" "+f2+" ");

            for(int i = 2; i < num; i++)
            {
                f = f1 + f2;
                f1 = f2;
                f2 = f;


                Console.Write(f+" ");
                

            }
        }
    }
    class FactSum
    {
         static void Main(string[] args)
        {
            long sum = 0;
            long fact= 1;
            Console.WriteLine("Enter Factorial Term = ");
            int num = int.Parse(Console.ReadLine());


            for(int i=1;i<=num;i++)
            {
                fact = fact * i;
                sum = sum + fact;
            }
            Console.WriteLine(" Factorial Sum = "+sum);
        }
    }
    class TwinPrime
    {
         static void Main(string[] args)
        {
            int num1, num2 ;
            int a = 0;
            int b = 0;
            int diff;
            Console.WriteLine("Enter First Number = ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second Number = ");
            num2 = int.Parse(Console.ReadLine());

            for(int i = 1; i <= num1; i++)
            {
                if (num1 % i == 0)
                    a++;

            }
            for(int i = 1; i <= num2; i++)
            {
                if (num2 % i == 0)
                    b++;
            }
            diff = num1 - num2;
            if((diff==2) || (diff==-2))

            {
                
                Console.WriteLine("Twin Prime");
            }
            else
            {
                Console.WriteLine("Not Twin Prime");
            }
        }
    }
    class Problem6
    {
        static void Main(string[] args)
        {
            int spc;
            int len = 1;
            int count = 0;
            Console.WriteLine("Enter The Number = ");
            count = Convert.ToInt32(Console.ReadLine());
            spc = count - 1;
            for (int i = 1; i <= count; i++)
            {
                for (int j = i; j <= spc; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= len; k++)
                {
                    Console.Write(i + " ");
                }
                spc--;
                len = len + 2;
                Console.WriteLine();
            }

        }

    }
    class Problem8
    {
         static void Main(string[] args)
        {
         for(int i=5;i>=1;i--)
            {
                for (int j = 5; j > i; j--)
                {

                    Console.Write(" ");
                }
                    for(int l = 1; l <= i; l++)
                    {
                        Console.Write(l);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
    



