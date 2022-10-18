using System;
namespace MyProject.Oops
{

    class Student1
    {
        int s_id;
        string name;
        int phy;
        int math;
        int chem;
        double per;
        public void Accept_Details(int id, string sname, int P, int m, int c)
        {
            s_id = id;
            name = sname;
            phy = P;
            math = m;
            chem = c;
        }

        public void Percentage(int phy, int math, int chem)
        {
            per = (phy + math + chem) / 3;
           // Console.WriteLine("Percentage=" + per + "%");

        }

        public void Display()
        {
            Console.WriteLine(s_id + " " + name + " " + phy + " " + math + " " + chem + " " + per);
        }
        static void Main(String[] args)
        {
            Student1 st = new Student1();
            st.Accept_Details(1, "RAM", 45, 72, 56);
            st.Percentage(45, 72, 56);
            st.Display();
        }
    }
    class Task1
    {
        
        int i;
        public void Num(int num)
        {
            int sum = 0;
           
            for (i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i);
                    sum = sum + i;
                }
            }
            Console.WriteLine(sum);
        }

      /*  public void Display()
        {
            Console.WriteLine();
        }*/

        static void Main(string[] args)
        {
            Task1 t = new Task1();
            // t.Num(8);

            t.Num(8);
        }
    }
}