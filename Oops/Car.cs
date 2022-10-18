using System;
namespace MyProject.Oops
{
     class Car
    {
        public int modelno;
        public string name;
        public int price;
        public string color;

         static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.modelno = 7;
            car1.name = "BMW";
            car1.price = 10000000;
            car1.color = "Red";
            Console.WriteLine(car1.modelno+" "+car1.name+" "+car1.price+" "+car1.color);

            Car car2 = new Car();
            car2.modelno = 1;
            car2.name = "Audi";
            car2.price = 15000000;
            car2.color = "Black";
            Console.WriteLine(car2.modelno + " " + car2.name + " " + car2.price + " " + car2.color);

            Car car3 = new Car();
            car3.modelno = 7;
            car3.name = "Range Rover";
            car3.price = 10000000;
            car3.color = "white";
            Console.WriteLine(car3.modelno + " " + car3.name + " " + car3.price + " " + car3.color);
        }
       
    }
    class Box
    {

        public float length;
        public float width;
        public float height;
        public float area;

         static void Main(string[] args)
        {
            Box box1 = new Box();
            box1.length = 10f;
            box1.width = 2f;
            box1.height = 4f;
            box1.area = box1.height * box1.length * box1.width;
            Console.WriteLine(box1.area);


        }
    }

    class Student
    {
        public int id;
        public string name;
        public float English;
        public float Maths;
        public float Science;
        public float total;
        public float Average;
        public float Percentage;

         static void Main(string[] args)
        
        {
            Student s1 = new Student();
            s1.id = 234;
            s1.name = "Ramesh";
            s1.English = 80;
            s1.Maths = 80;
            s1.Science = 80;
            s1.total =(s1.English+s1.Maths+s1.Science);
            s1.Average = s1.total / 3;
            s1.Percentage = (s1.total / 300) * 100;
            Console.WriteLine(s1.id+" "+s1.name+" "+s1.English+" "+s1.Maths+" "+s1.Science+" "+s1.total+" "+s1.Average+" "+s1.Percentage);


        }
    }
}
