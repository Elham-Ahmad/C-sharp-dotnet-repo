//  1.Write a C# program to validate an Email ID using – 
//  a.	Using Regex

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Assignment_2_1
    {
        public void assignment2_1()
        {
            string email = "";
            Console.WriteLine($"Enter your Email");
            email  = Console.ReadLine();

            string pattern = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
            if (Regex.IsMatch(email, pattern))
            {
                Console.WriteLine($"${email} is a valid email address");
            }
            else Console.WriteLine($"${email} is invalid email address");

        }
    }
}
