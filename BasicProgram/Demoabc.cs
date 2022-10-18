using System;
namespace MyProject.BasicProgram
{
    class Demoabc
    {

        static void Main(string[] args)
        {
            int a, b, c, x;
            a = 2;
            b = 2;
            c = 5;

            x = ++a - --b - --c;
            Console.WriteLine(x + " " + a + " " + b + " " + c);
        }
    }
}
