using FinalAssignment.Data;
using FinalAssignment.Data.Entities;
using System;
using System.Linq;

namespace FinalAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Students = new Student();

            Console.WriteLine("Lets add some Record in Database");

            Students.FirstName = "Ahmad";
            Students.LastName = "Tariq";
            Students.ClassName = "BS (CS)";
            Students.Gender = "Male";
            Students.RollNo = "023450-BSCS-17";
            Students.Section = "AE";



            var dbContext = new StudentDbContext();
            dbContext.students.Add(Students);
            dbContext.SaveChanges();
            Console.WriteLine("Student Record is Successfully addded to databse");

            Console.WriteLine("<!--------------------------------!>");

            Console.WriteLine("Student Record Application using .NET Core 5.0");
            Console.WriteLine("<!--------------------------------!>");
            Student dbStudent =dbContext.students.SingleOrDefault(s=>s.Id == Students.Id);
            Console.WriteLine("<!--------------------------------!>");

            Console.WriteLine("Get Student Record From dstabase which was added in this build ");
            Console.WriteLine("<!--------------------------------!>");

            Console.Write("Student FirstName : ");
            Console.WriteLine(dbStudent.FirstName);

            Console.Write("Student Lastname : ");
            Console.WriteLine(dbStudent.LastName);

            Console.Write("Student Class : ");
            Console.WriteLine(dbStudent.ClassName);

            Console.Write("Student Gender : ");
            Console.WriteLine(dbStudent.Gender);

            Console.Write("Student RollNo : ");
            Console.WriteLine(dbStudent.RollNo);

            Console.Write("Student Section : ");
            Console.WriteLine(dbStudent.Section);

        }
    }
}
