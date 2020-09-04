using System;
/*
Write a program to create a Shape Class and derive two child class, Rectangle and Circle, based 
the specification given in the Tutorial instructions.
 The Base class implementation is provided.
 */
namespace Week6LabProgram
{
    // Base Class Shape
    public class Shape
    {
        public int NumberOfSides { get; set; }

        public Shape(int NoSides)
        {
            NumberOfSides = NoSides;
        }

        public virtual void Area()
        {
            Console.WriteLine("I am from Shape Class");
        }
        public virtual void Display()
        {
            Console.WriteLine("The Number of Sides are: {0}", NumberOfSides);
        }
    }

    public class Circle : Shape
    {
        int side;
        double radius;
        const double pi = 3.142;
        double areaVal;

        public Circle(int side, double radius): base(side)
        {
            this.side = side;
            this.radius = radius;
        }

        public override void Area()
        {
            areaVal = pi * (radius * radius);
        }
      
        public override void Display()
        {
            Console.WriteLine("\nThe Number of sides of a Circle is : {0}", side);
            Console.WriteLine("The Radius of the Circle is: {0}", radius);
            Console.WriteLine("The Area of Circle is : {0}", areaVal);
        }
    }


    public class Rectangle : Shape
    {
        int side;
        double length;
        double breadth;
        double areaVal;
      
        public Rectangle(int side, double length, double breadth) : base(side)
        {
            this.side = side;
            this.length = length;
            this.breadth = breadth;
        }
       
        public override void Area()
        {
            areaVal = length * breadth;
        }

        public override void Display()
        {
            Console.WriteLine("\nThe Number of sides of a Rectangle is : {0}", side);
            Console.WriteLine("The Length and Breadth of the Rectangle is: {0}, {1}", length, breadth);
            Console.WriteLine("The Area of Rectangle is : {0}", areaVal);
        }
    }
    class Week6Program2
    {
        static void Main(string[] args)
        {
            Circle C1 = new Circle(1, 4);
            Rectangle R1 = new Rectangle(4, 5, 4);

            C1.Area();
            R1.Area();
            C1.Display();
            R1.Display();

            Console.ReadKey();       
        }
    }
}

/*
  Test Case:
    The Number of sides of a Circle is : 1
    The Radius of the Circle is: 4
    The Area of Circle is : 50.272

    The Number of sides of a Rectangle is : 4
    The Length and Breadth of the Rectangle is: 5, 4
    The Area of Rectangle is : 20
  
 */
