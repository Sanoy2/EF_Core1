using EF_Core.Models;
using EF_Core.Repos;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Core
{
    public class Dupa : App
    {
        public void Run()
        {
            using (var context = new SchoolContext())
            {
                IStudentRepo studentRepo = new StudentRepo(context);
                ICourseRepo courseRepo = new CourseRepo(context);
                using (IUoW uow = new UoW(context, studentRepo, courseRepo))
                {
                    var s = uow.StudentRepo.Get(6);
                    Console.WriteLine(s.ToString());
                    Course course = new Course("How to basic");
                    uow.CourseRepo.Add(course);
                    var participation = new CourseParticipation(s, course);
                    s.AddParticipation(participation);
                    course.AddParticipation(participation);
                    //uow.Commit();

                    uow.StudentRepo.PrintStudents();
                }
            }
        }
    }
}
