

//      2.Write a C# program to validate an Email ID using – 
//      a.	Custom logic with loop & conditions

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Question_2
    {
         void ValidateEmail(string email)
        {
            char[] array = email.ToCharArray();
           
            int counter_at_the_rate = 0;
            string dot_com="";

            int counter_dot_com = 0;

            int end_of_array = array.Length - 1;
            int eliminate_count = (array.Length - 1)-4;

            for (int i = end_of_array; i >= end_of_array-eliminate_count; i--)
            {
                dot_com +=array[i];
                if (dot_com == "moc.")
                {
                    counter_dot_com++;
                }
            }
            
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] == '@')
                {
                    counter_at_the_rate++;
                    
                }
                
            }
           

            if (counter_at_the_rate == 1 && counter_dot_com == 1) Console.WriteLine("Email is valid");
            else Console.WriteLine("Email is invalid");

        }
        public void question2()
        {
            string email = null;
            bool ans;
            Console.WriteLine($"\nEnter a email address to validate.");
            email = Console.ReadLine();
            ValidateEmail(email);
        }
    }
}
