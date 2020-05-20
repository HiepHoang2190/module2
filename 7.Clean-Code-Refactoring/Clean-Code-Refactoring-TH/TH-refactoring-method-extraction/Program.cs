using System;

namespace TH_refactoring_method_extraction
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = CylinderDemo.GetVolume(3, 5);
            Console.WriteLine(result);
        }
    }
}
