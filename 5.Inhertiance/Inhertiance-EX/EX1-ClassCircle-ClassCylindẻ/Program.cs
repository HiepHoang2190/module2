using System;

namespace EX1_ClassCircle_ClassCylindẻ
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(2.0, "red");
            
            Console.WriteLine(circle.ToString());
            Console.WriteLine(circle.GetArea());
            Cylinder cylinder = new Cylinder(3.0, "green", 4.0);
           
            Console.WriteLine(cylinder.ToString());
            Console.WriteLine(cylinder.GetVolume());
        }
    }

    class Circle
    {
        private double radius { get; set; }
        private string color { get; set; }

        public Circle(double radius,string color)
        {
            this.radius = radius;
            this.color = color;
        }

        public double GetRadius()
        {
            return radius;
        }
        public void SetRadius(double radius)
        {
            this.radius = radius;
        }
        public string GetColor()
        {
            return color;
        }
        public void SetColor(string color)
        {
            this.color = color;
        }
        public double GetArea()
        {
            return radius * radius * Math.PI;
        }
        public override String ToString()
        {
            return $"A Circle with radius= {GetRadius()}, Color:{GetColor()}";
        }
    }
    
    class Cylinder : Circle
    {
        private double height { get; set; }

        public Cylinder(double radius, string color, double height): base(radius, color)
        {
            this.height = height;
        }

        public double GetHeight()
        {
            return height;
        }
        public void SetHeight(double height)
        {
            this.height = height;
        }
        public double GetVolume()
        {
            return GetArea() * height;
        }

        public override String ToString()
        {
            return $"A Cylinder with Height= {GetHeight()}, Radius: {GetRadius()}, Color:{GetColor()}";
        }
    }
}
