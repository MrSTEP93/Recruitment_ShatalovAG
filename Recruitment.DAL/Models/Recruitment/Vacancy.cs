using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Recruitment.DAL.Models.Company;

namespace Recruitment.DAL.Models.Recruitment
{
    public class Vacancy(string name)
    {
        public int Id { get; set; }
        public string Name { get; set; } = name;
        public string Description { get; set; } = string.Empty;

        public Department? Department { get; set; }
        public Position? Position { get; set; }
        public Role? Role { get; set; }

        public int SuggestedSalary { get; set; }
    }
}
