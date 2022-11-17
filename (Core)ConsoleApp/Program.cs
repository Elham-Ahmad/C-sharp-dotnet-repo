using System;

namespace _Core_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new CoreCalculatorClass().Add(10, 2));
            Console.WriteLine(new CoreCalculatorClass().Subtract(10, 2));
            Console.WriteLine(new CoreCalculatorClass().Multiply(10, 2));
            Console.WriteLine(new CoreCalculatorClass().Divide(10, 2));
            Console.WriteLine(new CoreCalculatorClass().Modulus(10, 2));

            Console.ReadKey();

        }
    }
}
