using System;

namespace Class_Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("20kg", "1.5", "Tom");
            cat.PrintInfo();
        }
    }
    public abstract class Animal
    {
        protected string Weight { get; set; }
        protected string Height { get; set; }

        public Animal( string Weight, string Height)
        {
            this.Weight = Weight;
            this.Height = Height;
        }
        public abstract void PrintInfo();
    }
    public class Cat:Animal
    {
        private string Name { get; set; }

        public Cat(string Weight, string Height, string Name): base(Weight, Height)
        {
            this.Name = Name;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($" Weight: {Weight}\t Height: {Height} \t Name: {Name} \t");
        }
    }
}
