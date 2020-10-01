using EF_Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EF_Core.Repos
{
    public class CourseRepo : ICourseRepo
    {
        private readonly SchoolContext schoolContext;

        public CourseRepo(SchoolContext schoolContext)
        {
            this.schoolContext = schoolContext;
        }

        public void Add(Course course)
        {
            this.schoolContext.Courses.Add(course);
        }

        public IQueryable<Course> Get()
        {
            return this.schoolContext.Courses.Include(x => x.Parcipitations).AsQueryable();
        }
    }
}
