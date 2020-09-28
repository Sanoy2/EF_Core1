using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EF_Core.Models
{
    public class PersonalId
    {
        private string value;

        protected PersonalId() { }

        public PersonalId(string value)
        {
            this.EnsureValueOk(value);
            this.value = value;
        }
        
        public override string ToString()
        {
            return this.value;
        }

        private void EnsureValueOk(string value)
        {
            if(string.IsNullOrWhiteSpace(value) || value.Length < 5 || value.Length > 10)
            {
                throw new ArgumentException(nameof(value));
            }
        }
    }
}
