using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Core.Models
{
    public class StudentCard
    {
        public string Number { get; }
        public Student Student { get; }
        public DateTime Created { get; }

        protected StudentCard() { }

        public StudentCard(Student student, string number)
        {
            this.Student = student;
            this.Number = number;
            this.Created = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Card: {this.Number}, Created: {this.Created}";
        }
    }
}