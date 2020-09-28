using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Core.Models
{
    public class Course : Entity
    {
        public int Id { get; }
        public string CourseName { get; }

        protected Course()
        {

        }

        public Course(int id)
        {
            this.Id = id;
        }
    }
}
