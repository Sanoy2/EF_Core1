using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Core.ValueObjects
{
    public class PersonId
    {
        public string Value { get; }

        protected PersonId()
        {

        }

        public PersonId(string value)
        {
            this.Value = value;
        }

        public override string ToString()
        {
            return this.Value;
        }
    }
}
