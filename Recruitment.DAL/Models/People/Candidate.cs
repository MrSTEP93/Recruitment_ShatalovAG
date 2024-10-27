using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Recruitment.DAL.Models.Recruitment;

namespace Recruitment.DAL.Models.People
{
    /// <summary>
    /// Класс с описанием полей, специфичнных для кандидата.
    /// Здесь для упрощения, каждому кандидату указываю вакансию, на которую он претендует.
    /// Другой вариант - создать отдельную таблицу (класс) КандидатыНаВакансию.
    /// </summary>
    /// <param name="name">имя кандидата</param>
    /// <param name="email">адрес электронной почты</param>
    public class Candidate(string name, string email) : AbstractPerson(name, email)
    {
        public Vacancy? Vacancy { get; set; }
        public string ResumeURL { get; private set; } = string.Empty;
        public int ExpectedSalary { get; private set; } = 0;
    }
}
