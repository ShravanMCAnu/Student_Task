// See https://aka.ms/new-console-template for more information
using Student_Task;
try
{
    Operations objOperations = new Operations();
    List<Student> students = new();
    int choice = 0;
    do
    {
        Console.WriteLine("Hello Welcome to Student DataBase\n\n To perform opertions \n\t choose your options\n\t 1. Add \n\t 2. Edit \n\t 3. Delete \n\t 4.Display \n\t 5. Exit");
        choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                objOperations.AddStudent(students);
                break;
            case 2:
                objOperations.EditStudent(students);
                break;
            case 3:
                objOperations.DeleteStudent(students);
                break;
            case 4:
                objOperations.DisplayStudents(students);
                break;
        }
    }
    while (choice < 5);
    Console.WriteLine("Database is closed......press Enter Again to exit the console");
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}



