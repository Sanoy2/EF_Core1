using EF_Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Core.Models
{
    public class Student : Entity
    {
        public int Id { get; }
        public string Name { get; set; }
        public PersonId PersonalIdNumber { get; private set; }

        protected Student()
        {

        }

        public void UpdatePersonId(PersonId personId)
        {
            this.PersonalIdNumber = personId;
        }

        public Student(string name, string personalIdNumber)
        {
            this.Name = name;
            this.PersonalIdNumber = new PersonId(personalIdNumber);
        }

        public override string ToString()
        {
            return $"Id: {this.Id}, Name: {this.Name}, IdNumber: {this.PersonalIdNumber.ToString()}";
        }
    }
}
