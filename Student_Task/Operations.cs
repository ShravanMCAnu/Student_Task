using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Task
{
    public class Operations
    {
        public void AddStudent(List<Student> students)
        {
            Student objStudent;
            Console.WriteLine("How Many students Do you want to Add ?");
            int studentCount = int.Parse(Console.ReadLine());
            if (studentCount > 0)
            {
                for (int iterator = 1; iterator <= studentCount; iterator++)
                {
                    objStudent = new Student();
                    objStudent.GetSudentDetails();
                    students.Add(objStudent);
                }
                Console.WriteLine("Student Details Added");
            }
            else
            {
                Console.WriteLine("Error.......Give a Valid Number");
            }
        }
        public void DeleteStudent(List<Student> students)
        {
            Console.WriteLine("No. of Students are:" + students.Count);
            Console.WriteLine("Enter student Roll No to delete:");
            int rollNo = int.Parse(Console.ReadLine());
            if(students.Count > 0)
            {
                foreach(Student student in students)
                {
                    if (rollNo == student.StudentRollNo)
                    {
                        students.Remove(student);
                        Console.WriteLine("Student deleted Sucessfully");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("No Record Found");
            }
        }
        public void DisplayStudents(List<Student> students)
        {
            if(students.Count == 0)
            {
                Console.WriteLine("No record found......");
            }
            else
            {
                foreach (Student student in students)
                {
                    student.DisplayStudentDetails();
                }
            }
        }
        public void EditStudent(List<Student> students)
        {
            if (students.Count == null)
            {
                Console.WriteLine("No Data Found to Edit");

            }
            else if (students.Count > 0) 
            {
                Console.WriteLine("Students Info");
                DisplayStudents(students);
                Console.WriteLine("Enter Student Roll No to edit that particular student details...");
                int deleteStudent=int.Parse(Console.ReadLine());

                Console.WriteLine("Enter New Student Name");
                string newStudentName=Console.ReadLine();

                Console.WriteLine("Enter New Student Age");
                int newStudentAge = int.Parse(Console.ReadLine());
                foreach (Student student3 in students)
                {
                    if (deleteStudent == student3.StudentRollNo)
                    {
                        student3.StudentName = newStudentName;
                        student3.Age = newStudentAge;
                        Console.WriteLine("Student Details Edited....");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Student Details not found...");
                    }
                }
            }
        }

    }
}
