using System;

namespace EX1_Access_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();

            //Console.WriteLine(circle.GetRadius());
            //Console.WriteLine(circle.GetColor());
            circle.viewInfo();
            Circle circle2 = new Circle(20);
            //Console.WriteLine(circle2.GetRadius());
            //Console.WriteLine(circle2.GetColor());
            circle2.viewInfo();
        }

    }

    class Circle
    {
        #region fields
        private double radius = 1.0;
        private string color = "red";
        #endregion

        #region constructor
        public Circle()
        {

        }
        public Circle(double r)
        {
            radius = r;
        }
        #endregion

        #region public method

        private double GetRadius()
        {
            return radius;
        }
       
        private string GetColor()
        {
            return color;
        }
        public void viewInfo()
        {
            Console.WriteLine($"A Circle with radius= {GetRadius()}, Color:{GetColor()}");
        }
        #endregion

        #region private method
        #endregion
    }
}
