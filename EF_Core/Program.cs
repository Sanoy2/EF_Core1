using EF_Core.Models;
using System;
using System.Linq;

namespace EF_Core
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {
                if(context.Students.Any() == false)
                {
                    Student student = new Student("John Doe", "18291828");
                    context.Students.Add(student);
                }

                context.SaveChanges();
                Print(context);
                
            }
        }

        private static void Print(SchoolContext schoolContext)
        {
            foreach (var student in schoolContext.Students)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}
