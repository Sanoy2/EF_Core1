using EF_Core.Models;
using Microsoft.EntityFrameworkCore;
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
                    student.AddCard(Guid.NewGuid().ToString().Substring(0, 6));
                    context.Students.Add(student);
                    context.SaveChanges();
                }
                else
                {
                    Student student = context.Students.First();
                    student.UpdatePersonId(new ValueObjects.PersonId(Guid.NewGuid().ToString().Substring(0, 10)));

                    context.SaveChanges();
                }

                
                Print(context);
                
            }
        }

        private static void Print(SchoolContext schoolContext)
        {
            foreach (var student in schoolContext.Students.Include(x => x.Cards))
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}
