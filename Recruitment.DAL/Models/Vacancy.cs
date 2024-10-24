using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.DAL.Models
{
    public class Vacancy(string name)
    {
        public string Name { get; set; } = name;
        public string? Description { get; set; }

        public Department? Department { get; set; }
        public Position? Position { get; set; }
        public Role? Role { get; set; }

        private int calculatedSalary;
        public int CalculatedSalary {  get; private set; }

        private int salary;
        public int Salary { get; private set; }


        /*
        public void CalculateSalary()
        {
            if (Position != null)
            {
                calculatedSalary = Position.BaseSalary;
                if (Role != null)
                {
                    calculatedSalary = (int)Math.Round(calculatedSalary * Role.SalaryMultiplier);
                }
            } else
            {
                calculatedSalary = 0;
            }
        }
        */
    }
}
