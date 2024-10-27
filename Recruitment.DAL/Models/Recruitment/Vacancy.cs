using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Recruitment.DAL.Models.Company;

namespace Recruitment.DAL.Models.Recruitment
{
    /// <summary>
    /// Класс с описанием вакансии
    /// </summary>
    /// <param name="name">Название вакансии</param>
    public class Vacancy(string name)
    {
        public int Id { get; internal set; }
        public string Name { get; internal set; } = name;
        public string Description { get; internal set; } = string.Empty;

        public Department? Department { get; internal set; }
        public Position? Position { get; internal set; }
        public Grade? Role { get; internal set; }

        public int SuggestedSalary { get; internal set; }
    }
}
