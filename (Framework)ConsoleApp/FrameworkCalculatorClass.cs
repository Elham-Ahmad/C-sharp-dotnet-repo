using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Framework_ConsoleApp
{
    internal class FrameworkCalculatorClass
    {
        public string Add (int num1,int num2)
        {
            return $"addition of {num1} and {num2} is {num1 + num2}";
        }

        public string Subtract (int num1,int num2)
        {
            return $"Subtraction of {num1} and {num2} is {num1 -num2}";
        }
        public string Multiply(int num1, int num2)
        {
            return $"Multiplication of {num1} and {num2} is {num1 * num2}";
        }
        public string Divide(int num1, int num2)
        {
            return $"Division  of {num1} and {num2} is {num1 / num2}";
        }
        public string  Modulus(int num1, int num2)
        {
            return $"Modulus  of {num1} and {num2} is {num1 % num2}";
        }
    }
}
