//  1.Write a C# program that performs all string operations
//  like COMPARE, CONCAT, SUBSTRING, REVERSE using – 

//  a.	Manual Array operations for character array ‘char[]’

//  b.  Built -in functions for ‘string’ variables


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace ConsoleApp1
{
    internal class Question_1
    {
        public void question1_1()
        {

            void CompareUsingBuiltIn(string str1, string str2)
            {
                if (String.Compare(str1, str2) == 0) Console.WriteLine("Both strings are equal!");
                else Console.WriteLine("string are unequal");
            }

            void ConcateUsingBuiltIn(string str1,string str2)
            {
                string concate_str = String.Concat(str1, str2);
                Console.WriteLine("\nString after Concatination {0}", concate_str);

            }

            void SubStrUsingBuiltIn(string str)
            {
                int startindex, endindex;
                Console.WriteLine("\nEnter starting index of the string\n");
                startindex = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nEnter end index of the string\n");
                endindex = Convert.ToInt32(Console.ReadLine()); 
                Console.WriteLine("\nString after triming\n");
               Console.WriteLine( str.Substring(startindex, endindex));
            }

            void ReverseUsingBuiltIn(string str)
            {

                char[] array = str.ToCharArray();
                 Array.Reverse(array);
                Console.WriteLine(array);
              
            }

            void CompareManually(string str1,string str2)
            {
                if (String.Equals(str1, str2))
                    Console.WriteLine($"{str1} and {str2} are same.");
                else Console.WriteLine($"{str1} and {str2} are not same.");
            }
            void ConcateManually(string str1,string str2)
            {

                Console.WriteLine($"result after concatenate {str1} and {str2} is {str1 + str2}");
            }
            void SubStrManually(string str)
            {
                string substr ="";
                int startindex, endindex;
                Console.WriteLine("\nEnter starting index of the string\n");
                startindex = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nEnter end index of the string\n");
                endindex = Convert.ToInt32(Console.ReadLine());

                for(int i = startindex; i < endindex; i++)
                {
                    substr += str[i];
                }
                Console.WriteLine($"Substring of {str} is {substr}"); 

            }
            void ReverseManually(string str)
            {


                int a;
                string rev = "";
                a = str.Length - 1;
                while (a >= 0)
                {
                    rev = rev + str[a];
                    a--;
                }
                Console.WriteLine("String after reversing is {0}", rev);
            }

            while (true)
            {


                Console.WriteLine("\n\tMenu");
                Console.WriteLine("\nPress 1 for Compare two strings Using Built-In Functions");
                Console.WriteLine("\nPress 2 for Concate two strings Using Built-In Functions");
                Console.WriteLine("\nPress 3 for perform Substring operation Using Built-In Functions");
                Console.WriteLine("\nPress 4 for Reversing a string Using Built-In Functions");
                Console.WriteLine("\nPress 5 for Compare two strings Manually");
                Console.WriteLine("\nPress 6 for Concate two strings Manually");
                Console.WriteLine("\nPress 7 for perform Substring operation Manually");
                Console.WriteLine("\nPress 8 for Reversing a string Manually");



                Console.WriteLine("\nPress  for cancel the current operation");


                Console.WriteLine("enter your choice :");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        
                        string str1;
                        string str2;

                        Console.WriteLine("\nenter a first string :\n");
                        str1 =  Console.ReadLine();
                        Console.WriteLine("\nenter second string  :\n");
                        str2 = Console.ReadLine();
                        CompareUsingBuiltIn(str1, str2);
                     break;

                     case 2:
                        string strg1;
                        string strg2;

                        Console.WriteLine("\nenter a first string :\n");
                        strg1 = Console.ReadLine();
                        Console.WriteLine("\nenter second string  :\n");
                        strg2 = Console.ReadLine();
                        ConcateUsingBuiltIn(strg1, strg2);

                        break;
                    
                    case 3:
                       
                        string strh1;
                      
                        Console.WriteLine("\n Enter a String to perform Substring operation:\n");
                        strh1= Console.ReadLine();
                        SubStrUsingBuiltIn(strh1);

                        break;

                    case 4:
                            string strh2;
                        Console.WriteLine("\nEnter a string to reverse");
                        strh2 = Console.ReadLine();
                        ReverseUsingBuiltIn(strh2);
                        break;
                   
                    case 5:

                        string stri1;
                        string stri2;

                        Console.WriteLine("\nenter a first string :\n");
                        stri1 = Console.ReadLine();
                        Console.WriteLine("\nenter second string  :\n");
                        stri2 = Console.ReadLine();
                        CompareManually(stri1, stri2);
                        break;

                    case 6:
                        string strj1;
                        string strj2;

                        Console.WriteLine("\nenter a first string :\n");
                        strj1 = Console.ReadLine();
                        Console.WriteLine("\nenter second string  :\n");
                        strj2 = Console.ReadLine();
                        ConcateManually(strj1, strj2);

                        break;

                    case 7:
                        string strk1;
                       

                        Console.WriteLine("\nenter a first string :\n");
                        strk1 = Console.ReadLine();
                      
                        SubStrManually(strk1);

                        break;
                    case 8:
                        string strm1;


                        Console.WriteLine("\nenter a first string :\n");
                        strm1 = Console.ReadLine();

                        ReverseManually(strm1);

                        break;
                  
                    case 9:
                        break;


                }

                Console.WriteLine("\nDo you want to stop program\n press 1 for yes and 0 for no");
                int ans  = Convert.ToInt32(Console.ReadLine());
                if (ans == 1)
                    break;
                else continue;

            }

            

        }
    }
}
