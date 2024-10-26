using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Recruitment.DAL.Models.Company;

namespace Recruitment.DAL.Models.People
{
    public class Employee : AbstractPerson
    {
        public Employee(string name, string email) : this(name, string.Empty, email, string.Empty) { }

        public Employee(string name, string lastName, string email, string phone) : base(name, lastName, email, phone)
        {
        }

        public Department? Department { get; set; }
        public Position? Position { get; set; }
        public Role? Role { get; set; }
    }
}
