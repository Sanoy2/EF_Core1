using EF_Core.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EF_Core
{
    class Dupa2 : App
    {
        public void Run()
        {
            using (var context = new SchoolContext())
            {
                IStudentRepo studentRepo = new StudentRepo(context);
                ICourseRepo courseRepo = new CourseRepo(context);
                using (IUoW uow = new UoW(context, studentRepo, courseRepo))
                {
                    var s = uow.StudentRepo.Get().First();

                    s.AddCard(Guid.NewGuid().ToString().Substring(0, 10));

                    uow.StudentRepo.PrintStudents();

                    //uow.Commit();
                }
            }
        }
    }
}
