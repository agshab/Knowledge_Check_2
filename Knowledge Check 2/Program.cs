using System;

namespace Knowledge_Check_2
{

    internal class Program
    {

        static void Main(string[] args)

        { 
            Console.WriteLine("How many students would you like to add?");
            int numberOfStudents = int.Parse(Console.ReadLine());



            List<Student> studentsList = new List<Student>();
            for (int i = 0; i < numberOfStudents; i++) i = i + 1; //i++ means add 1 to i to once, each time/
            {
                Student student = new Student();


                Console.WriteLine("Please enter the student's first name.");
                student.FirstName = Console.ReadLine();

                Console.WriteLine("Please enter the student's last name.");
                student.LastName = Console.ReadLine();

                Console.WriteLine("Please enter the student's gnder.");
                student.Gender = Console.ReadLine();

                Console.WriteLine("Please assign the student's ID");
                int.TryParse(Console.ReadLine(), out int result);
                student.StudentID = result;

                Console.WriteLine("Please enter the student's GPA.");
                decimal.TryParse(Console.ReadLine(), out decimal GPAresult);
                student.GPA = GPAresult;


                Console.WriteLine("Please enter the student's Major.");
                student.Major = Console.ReadLine();


                studentsList.Add(student);

               



            }

            foreach(var Student in studentsList)
            {

                Console.WriteLine($"The student first name is:      {Student.FirstName} \n" +
                                    $"The Student last name is:     {Student.LastName}\n"+
                                    $"The student gender is:        {Student.Gender}\n" +
                                    $"The student ID is:            {Student.StudentID}\n" +
                                    $"The student GPA is:           {Student.GPA}\n" +
                                    $"The student major is:         {Student.Major}\n");
            }

            //int a = 1;
            //a++;
            //Console.WriteLine(a);

            //Student s = Console.ReadLine();

        }
    }
}