using EF_Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EF_Core.Repos
{
    public interface ICourseRepo
    {
        void Add(Course course);

        IQueryable<Course> Get();
    }
}
