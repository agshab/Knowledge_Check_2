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
            for (int i = 0; i < numberOfStudents; i++) //i++ means add 1 to i to once, each time/
            {
                Student newstudent = new Student();


                Console.WriteLine("Please enter the student's first name.");
                newstudent.FirstName = Console.ReadLine();

                Console.WriteLine("Please enter the student's last name.");
                newstudent.LastName = Console.ReadLine();

                Console.WriteLine("Please enter the student's gnder.");
                newstudent.Gender = Console.ReadLine();

                Console.WriteLine("Please assign the student's ID");
                int.TryParse(Console.ReadLine(), out int result);
                newstudent.StudentID = result;

                Console.WriteLine("Please enter the student's GPA.");
                decimal.TryParse(Console.ReadLine(), out decimal GPAresult);
                newstudent.GPA = GPAresult;


                Console.WriteLine("Please enter the student's Major.");
                newstudent.Major = Console.ReadLine();


                studentsList.Add(newstudent);

               



            }

            foreach(var x in studentsList) // "x" here is an object just like "i" in the foc loop above and "newstudent" above
            {

                Console.WriteLine($"The student first name is:      {x.FirstName} \n" +
                                    $"The Student last name is:     {x.LastName}\n"+
                                    $"The student gender is:        {x.Gender}\n" +
                                    $"The student ID is:            {x.StudentID}\n" +
                                    $"The student GPA is:           {x.GPA}\n" +
                                    $"The student major is:         {x.Major}\n");
            }

            //int a = 1;
            //a++;
            //Console.WriteLine(a);

            //Student s = Console.ReadLine();
            Console.ReadLine();
        }
    }
}