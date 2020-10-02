using EF_Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EF_Core.Models
{
    public class Student : Entity
    {
        private IList<StudentCard> cards;
        private IList<CourseParticipation> participations;

        public int Id { get; }
        public string Name { get; set; }
        public PersonId PersonalIdNumber { get; private set; }
        public IEnumerable<StudentCard> Cards => this.cards.OrderByDescending(x => x.Created);
        public IEnumerable<CourseParticipation> Participations => this.participations;

        protected Student()
        {
            this.cards = new List<StudentCard>();
            this.participations = new List<CourseParticipation>(); ;
        }

        public void UpdatePersonId(PersonId personId)
        {
            this.cards = new List<StudentCard>();
            this.PersonalIdNumber = personId;
        }

        public Student(string name, string personalIdNumber) : this()
        {
            this.Name = name;
            this.PersonalIdNumber = new PersonId(personalIdNumber);
        }

        public void AddCard(string cardNumber)
        {
            StudentCard card = new StudentCard(this, cardNumber);
            this.cards.Add(card);
        }

        public void AddParticipation(CourseParticipation participation)
        {
            this.participations.Add(participation);
        }

        public override string ToString()
        {
            var builder = new StringBuilder();

            string basicData = $"Id: {this.Id}, Name: {this.Name}, IdNumber: {this.PersonalIdNumber.ToString()}";
            
            builder.AppendLine(basicData);

            foreach (var item in this.Cards)
            {
                builder.AppendLine(item.ToString());
            }

            return builder.ToString();
        }
    }
}
