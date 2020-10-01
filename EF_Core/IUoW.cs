using EF_Core.Repos;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Core
{
    public interface IUoW : IDisposable
    {
        IStudentRepo StudentRepo { get; }
        ICourseRepo CourseRepo { get; }

        void Commit();
    }
}
