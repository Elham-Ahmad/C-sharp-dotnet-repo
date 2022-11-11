using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Student
    {
        int stud_id;
        string stud_name;
        string stud_dept;
        int stud_semester;

        
        // overriding the ToString function to print id,name,dept and semester 
        public override string ToString()
        {
            return stud_id + "\t" + stud_name + "\t" +
                   stud_dept + "\t\t" + stud_semester;
        }

        public void run()
        {
            // A List variable to store Student information
            List<Student> students = new List<Student>()
            {
                new Student{ stud_id =101,stud_name ="elham",stud_dept="MCA",stud_semester = 2 },
                new Student{ stud_id =102,stud_name ="atik",stud_dept="CSE",stud_semester = 1 },
                new Student{ stud_id =101,stud_name ="shaziya",stud_dept="EEE",stud_semester = 4 },

            };

            // Iterating through students details 
               IEnumerable<Student> query = from student in students select student;

            // Printing student details 
            Console.WriteLine("ID\tName\tDepartment\tSemester");
            Console.WriteLine("-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+");
            foreach (Student item in query)
            {
                Console.WriteLine(item.ToString());
            }

        }   

    }
    internal class Assignment_2_3:Student
    {
        public void assignment2_3()
        {


            //calling run method in Student class 
            Student student = new Student();
            student.run();

          

        }
    }
}
