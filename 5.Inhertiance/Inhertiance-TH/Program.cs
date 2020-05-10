using System;

namespace Inhertiance_TH
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Shape();
            Console.WriteLine(shape);

            Shape shape2 = new Shape("red", false);
            Console.WriteLine(shape2);

            Circle circle = new Circle();
            Console.WriteLine(circle);
            Circle circle2 = new Circle(3.5);
            Console.WriteLine(circle2);
            Circle circle3 = new Circle(3.5,"indigo",false);
            Console.WriteLine(circle3);

            Rectangle rectangle = new Rectangle();
            Console.WriteLine(rectangle);

            rectangle = new Rectangle(2.3, 5.8);
            Console.WriteLine(rectangle);

            rectangle = new Rectangle(2.5, 3.8, "orange", true);
            Console.WriteLine(rectangle);


            Square square = new Square();
            Console.WriteLine(square);
            square = new Square(2.3);
            Console.WriteLine(square);
            square = new Square(5.8, "yellow", true);
            Console.WriteLine(square);
        }
    }
}
