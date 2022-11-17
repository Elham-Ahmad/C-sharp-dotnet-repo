using System;
using System.Collections.Generic;
using System.Text;

namespace _Core_ConsoleApp
{
    internal class CoreCalculatorClass
    {
        public string Add(int num1, int num2)
        {
            return $"addition of {num1} and {num2} is {num1 + num2}";
        }

        public string Subtract(int num1, int num2)
        {
            return $"Subtraction of {num1} and {num2} is {num1 - num2}";
        }
        public string Multiply(int num1, int num2)
        {
            return $"Multiplication of {num1} and {num2} is {num1 * num2}";
        }
        public string Divide(int num1, int num2)
        {
            return $"Division  of {num1} and {num2} is {num1 / num2}";
        }
        public string Modulus(int num1, int num2)
        {
            return $"Modulus  of {num1} and {num2} is {num1 % num2}";
        }
    }
}

