using System;

namespace TH_Refactoring__Rename_Variables_and_Split_Constants
{
    class CalculatorTest
    {
        const char ADDITION = '+';
        const char SUBTRACTION = '-';
        const char MULTIPLICATION = '*';
        const char DIVISION = '/';
        static void Main(string[] args)
        {
            int result = Calculator.Calculate(3, 4,ADDITION );
            Console.WriteLine(result);
        }
    }
}
