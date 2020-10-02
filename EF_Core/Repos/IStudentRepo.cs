using EF_Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EF_Core.Repos
{
    public interface IStudentRepo
    {
        void Add(Student student);

        IQueryable<Student> Get();

        Student Get(int studentId);

        void PrintStudents();
    }
}
