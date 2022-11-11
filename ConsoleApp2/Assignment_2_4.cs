using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
    internal class Assignment_2_4
    {
        public void assignment2_4()
        {
            string filePath = @"C:\Demo\test.txt";
            
            // Reading from a file

            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filePath).ToList();

            foreach (string line in lines) 
            {
                Console.WriteLine(line);
            }
            
            // writing to a file 

            lines.Add("John, Doe, www.nobody.com");
            File.WriteAllLines(filePath, lines);

            Console.ReadLine();
     
          
        }
    }
}
