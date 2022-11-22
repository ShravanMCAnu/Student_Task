using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Task
{
    public class Student
    {
        public Student()
        {
                
        }
        public int StudentRollNo { get; set; }
        public string? StudentName { get; set; }
        public int Age { get; set; }

        public void GetSudentDetails()
        {
            Console.WriteLine("Enter Student Roll No:");
            this.StudentRollNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student Name:");
            this.StudentName = Console.ReadLine();
            Console.WriteLine("Enter Student Age:");
            this.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
        }
        public void DisplayStudentDetails()
        {

            Console.WriteLine("Student Roll No: {0}\nStudent Name: {1}\nStudent Age: {2}", this.StudentRollNo, this.StudentName,this.Age);
            Console.WriteLine("===============================================");
        }
    }
}
