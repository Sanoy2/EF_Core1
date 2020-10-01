using EF_Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EF_Core.Repos
{
    public class StudentRepo : IStudentRepo
    {
        private readonly SchoolContext schoolContext;

        public StudentRepo(SchoolContext schoolContext)
        {
            this.schoolContext = schoolContext;
        }

        public void Add(Student student)
        {
            this.schoolContext.Students.Add(student);
        }

        public IQueryable<Student> Get()
        {
            return schoolContext.Students.Include(x => x.Cards).Include(x => x.Participations);
        }

        public Student Get(int studentId)
        {
            return schoolContext.Students.Include(x => x.Cards)
                .Include(x => x.Participations)
                .FirstOrDefault(x => x.Id == studentId);
        }
    }
}
