using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Assignment_2_2
    {



        public void assignment2_2()
        {

             void DemoNullReference()

             { 

                try
                {
                    string str = null;
                    Console.WriteLine(str.Length);
                }
                catch (NullReferenceException err)
                {

                    Console.WriteLine("string is null ");
                    Console.WriteLine(err.Message);

                }
                Console.ReadLine();

            }
             void DemoDivideByZero()
             {
                int num1, num2, div;
                
                try
                {

                    Console.WriteLine("\nEnter first value");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nEnter second value");
                    num2 = Convert.ToInt32(Console.ReadLine());



                    if (num2 != 0)
                    {
                        div = num1 / num2;
                        Console.WriteLine(div);
                    }
                    else
                    {
                        div = num1/num2;
                    }
                    
                }
                catch(DivideByZeroException err)
                {
                    Console.WriteLine("divide by zero exception occurs");
                    Console.WriteLine(err.Message);

                }
             }
             void DemoStackOverflow()
            {
                byte b = 255;
                checked
                {
                    // this line will throw an error 

                        b++;
                }
                Console.WriteLine(byte.MaxValue);
                Console.WriteLine(b);

            }
             void DemoGeneric()
             {

             }


            while (true)
            {
                int choice;
                int ans; 

                Console.WriteLine("\nPress 1 to demonstrates NullReference\nPress 2 to demonstrates DivideByZero\nPress 3 to demonstrates  StackOverFlow\nPress 4 to demonstrates  Generic exceptions.\nPress 5 to cancel operation");
                Console.WriteLine("\nEnter your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        DemoNullReference();
                        break;
                    
                    case 2:
                        DemoDivideByZero();
                        break;
                    case 3:
                        DemoStackOverflow();
                        break;
                    case 4:
                        DemoGeneric();
                        break;
                    case 5:
                        break;


                }



                Console.WriteLine("\nDo you want to terminate the program ?\nEnter 1 for yes and 0 for no");

                ans = Convert.ToInt32(Console.ReadLine());
                if (ans == 1)
                {
                    break;
                }
                else continue;
            }
         

        }
    }
}
