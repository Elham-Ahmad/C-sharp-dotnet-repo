using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  Write a C# Program to sort a list of employees based on salary in descending order
//  and whose department is XYZ 


namespace ConsoleApp2
{
    class Employees
    {
        int emp_id;
        string emp_name;
        int emp_age;
        string emp_dept;
        float emp_salary;

        public override string ToString()
        {
            return "\t" + emp_id + "\t" + emp_name + "\t" + emp_age + "\t" + emp_dept + "\t" + emp_salary+"\n" ;
        }

        public void run()
        {
            List<Employees> employees = new List<Employees>()
            {
                new Employees { emp_id = 101, emp_name = "arjun", emp_age=23, emp_dept="XYZ",emp_salary = 30000 },
                new Employees { emp_id = 102, emp_name = "elham", emp_age=24, emp_dept="ABC",emp_salary = 34000 },
                new Employees { emp_id = 103, emp_name = "payal", emp_age=21, emp_dept="XYZ",emp_salary = 40000 },
                new Employees { emp_id = 104, emp_name = "kishan",emp_age=23, emp_dept="XYZ",emp_salary = 45000 },

            };

           

            var query = employees.Where(emp => emp.emp_dept == "XYZ").OrderByDescending(
                                        sal => sal.emp_salary);

            foreach ( Employees employee in query)
            {
                Console.WriteLine(employee.emp_id + "\t"+ employee.emp_name + "\t" 
                    + employee.emp_age + "\t" + employee.emp_dept + "\t" +employee.emp_salary);

            }
          
        }
    }
    internal class Assignment_2_5
    {
        public void assignment2_5()
        {
            Employees employees = new Employees();
            employees.run();
        }
    }
}
