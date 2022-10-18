using System;
namespace MyProject.BasicProgram
{
     class abc
    {
         static void Main(string[] args)
        {
            int a, b, x;
            a = 3;
            b = 3;

            x = ++a - --b + a;
            Console.WriteLine(x+ " "+a+" "+b);
        }
        
        }
    class xyz
    {
         static void Main(string[] args)
        {
            int a, b,c,x;
            a = 2;
            b = 2;
            c = 5;

            x = a++ + b++ + c++; 
            Console.WriteLine(x+ " "+a+" "+b+" " +c);
            x = ++a - --b - --c;
            Console.WriteLine(x+ " " +a+ " " +b+ " " +c);
            x = --a - b-- - --c;
            Console.WriteLine(x+ " " +a+ " " +b+ " " +c);
            x = a++ - ++b - ++c;
            Console.WriteLine(x+ " " +a+ " " +b+ " " +c);
            x = ++c + c + ++b;
            Console.WriteLine(x+  " " +a+ " " +b+ " "+c);

        }
    }
    class mnc
    {
         static void Main(string[] args)
        {
            int x ,ans;
            x = 4;
            ans = x++ + ++x - ++x + --x + x-- - x++ + x-- - x++ - --x + x++;
            Console.WriteLine(ans);
        }
    }
    class abc1
    {
        static void Main(string[] args)
        {
            Console.WriteLine(8*9/3*2-4);
        }
    }
    
    }

