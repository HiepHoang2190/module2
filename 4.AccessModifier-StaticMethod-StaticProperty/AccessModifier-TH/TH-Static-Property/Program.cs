using System;

namespace TH_Static_Property
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Mazda3", "Sky Active 3");
            Console.WriteLine(Car.numberOfCars);
            Car car2 = new Car("Mazda6", "Sky Active 6");
            Console.WriteLine(Car.numberOfCars);
            Console.ReadLine();

        }
    }

    class Car
    {
        #region fields

        private string name { get; set; }
        private string engine { get; set; }
        public static int numberOfCars { get; set; }
        #endregion

        #region constructor

        public Car (string name, string engine)
        {
            this.name = name;
            this.engine = engine;
            numberOfCars++;
        }
        #endregion

        #region public method
        #endregion

        #region private method
        #endregion
    }
}
