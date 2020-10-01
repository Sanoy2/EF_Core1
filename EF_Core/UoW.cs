using EF_Core.Repos;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Core
{
    public class UoW : IUoW
    {
        private readonly SchoolContext schoolContext;
        private readonly IStudentRepo studentRepo;
        private readonly ICourseRepo courseRepo;

        public IStudentRepo StudentRepo => this.studentRepo;

        public ICourseRepo CourseRepo => this.courseRepo;

        public UoW(SchoolContext schoolContext, IStudentRepo studentRepo, ICourseRepo courseRepo)
        {
            this.schoolContext = schoolContext;
            this.studentRepo = studentRepo;
            this.courseRepo = courseRepo;
        }

        public void Commit()
        {
            this.schoolContext.SaveChanges();
        }

        public void Dispose()
        {
            this.schoolContext.Dispose();
        }
    }
}
