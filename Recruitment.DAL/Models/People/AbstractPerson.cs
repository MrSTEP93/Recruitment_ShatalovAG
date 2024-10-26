using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.DAL.Models.People
{
    public abstract class AbstractPerson
    {
        protected AbstractPerson(string name, string email) : this(name, string.Empty, email, string.Empty) { }

        protected AbstractPerson(string name, string lastName, string email, string phoneNumber)
        {
            Name = name;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

    }
}
