using System;

namespace demo
{
    class Program
    {
       unsafe static void Main(string[] args)
        {
            Console.WriteLine("Input your number: ");
            int number = int.Parse(Console.ReadLine());
            int* pt = &number;
            

        }
    }
}
