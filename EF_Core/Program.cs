using EF_Core.Models;
using EF_Core.Repos;
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
                IStudentRepo studentRepo = new StudentRepo(context);
                ICourseRepo courseRepo = new CourseRepo(context);
                using(IUoW uow = new UoW(context, studentRepo, courseRepo))
                {
                    var s = uow.StudentRepo.Get(6);
                    Console.WriteLine(s.ToString());
                    Course course = new Course("How to basic");
                    uow.CourseRepo.Add(course);
                    var participation = new CourseParticipation(s, course);
                    s.AddParticipation(participation);
                    course.AddParticipation(participation);
                    //uow.Commit();

                    Print(context);
                }
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
