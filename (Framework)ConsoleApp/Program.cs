using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Framework_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(new FrameworkCalculatorClass().Add(10,2));
            Console.WriteLine(new FrameworkCalculatorClass().Subtract(10, 2));
            Console.WriteLine(new FrameworkCalculatorClass().Multiply(10, 2));
            Console.WriteLine(new FrameworkCalculatorClass().Divide(10, 2));
            Console.WriteLine(new FrameworkCalculatorClass().Modulus(10, 2));

            Console.ReadKey();


        }
    }
}
