using System;
using System.Collections.Generic;
using System.Text;

namespace TH_Refactoring__Rename_Variables_and_Split_Constants
{
    class Calculator
    {
        const char ADDITION = '+';
        const char SUBTRACTION = '-';
        const char MULTIPLICATION = '*';
        const char DIVISION = '/';
        public static int Calculate(int firstOperand, int secondOperand, char mathOperator)
        {
            switch (mathOperator)
            {
                case ADDITION:
                    return firstOperand + secondOperand;
                case SUBTRACTION:
                    return firstOperand - secondOperand;
                case MULTIPLICATION:
                    return firstOperand * secondOperand;
                case DIVISION:
                    if (secondOperand != 0)
                        return firstOperand / secondOperand;
                    else
                        throw new Exception("Can not divide by 0");
                default:
                    throw new Exception("Unsupported operation");
            }
        }
    }
}
