using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Core.Models
{
    public class CourseParticipation
    {
        public int Id { get; }
        public Student Student { get; }
        public Course Course { get; }

        protected CourseParticipation() { }

        public CourseParticipation(Student student, Course course)
        {
            this.Student = student;
            this.Course = course;
        }
    }
}
