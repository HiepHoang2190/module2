using System;

namespace Calculator_BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n Please enter a height: ");
            double height = double.Parse(Console.ReadLine());
            Console.Write("\n Please enter a weight: ");
            double weight = double.Parse(Console.ReadLine());

            double bmi = weight/(Math.Pow(height,2.0));
            bmi = Math.Round(bmi, 1);
            Console.WriteLine("BMI: "+ bmi);
            if (bmi < 18)
            {
                Console.WriteLine(" Underweight");
            }else if (bmi<25.0)
            {
                Console.WriteLine(" Normal");
            }
            else if (bmi < 30.0)
            {
                Console.WriteLine(" Overweight");
            }else
            {
                Console.WriteLine(" Obese");
            }

            
        }
    }
}
