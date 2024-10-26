using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Recruitment.DAL.Models.Company;

namespace Recruitment.DAL.Models.People
{
    [Table("Employees")]
    public class Employee : AbstractPerson
    {
        public Employee(string name, string email) : this(name, string.Empty, email, string.Empty) { }

        public Employee(string name, string lastName, string email, string phone) : base(name, lastName, email, phone)
        {
            PersonalSalaryMultiplier = 1.0;
        }

        public Department? Department { get; set; }
        public Position? Position { get; set; }
        public Role? Role { get; set; }

        private int calculatedSalary;
        public int CalculatedSalary { 
            get 
            {
                calculatedSalary = (Position == null) ? 0 : Position.BaseSalary;
                calculatedSalary = (Role == null) ? 0 : (int)Math.Round(calculatedSalary * Role.SalaryMultiplier);

                return calculatedSalary;
            }
        }

        public double PersonalSalaryMultiplier { get; private set; }

        private int finalSalary;
        public double FinalSalary => finalSalary = (int)Math.Round(calculatedSalary * PersonalSalaryMultiplier);

    }
}
