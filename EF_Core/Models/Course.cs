using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Core.Models
{
    public class Course : Entity
    {
        private IList<CourseParticipation> participations;

        public int Id { get; }
        public string CourseName { get; }

        public IEnumerable<CourseParticipation> Parcipitations => participations;

        protected Course()
        {
            this.participations = new List<CourseParticipation>();
        }

        public Course(string name) : this()
        {
            this.CourseName = name;
        }

        public void AddParticipation(CourseParticipation participation)
        {
            this.participations.Add(participation);
        }
    }
}
