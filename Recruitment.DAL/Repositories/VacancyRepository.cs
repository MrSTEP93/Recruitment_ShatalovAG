using Recruitment.DAL.Models.Company;
using Recruitment.DAL.Models.Recruitment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.DAL.Repositories
{
    public class VacancyRepository(AppDbContext db) : Repository<Vacancy>(db)
    {
        public void Add(string name, string description)
        {
            Add(name, description, 0);
        }

        public void Add(string name, string description, int salary)
        {
            Vacancy vacancy = new(name)
            {
                Description = description,
            };
            Create(vacancy);

            // в идеале, этот репо нужно получить из Dependecy Injection, но данный контейнер здесь не реализован
            var vacancyHistory = new VacancyHistoryRepository(db);
            vacancyHistory.InitFirstRecord(vacancy);

            SetSalary(vacancy, salary);
        }

        public void SetDepartment(Vacancy vacancy, Department department)
        {
        }

        public void SetPosition(Vacancy vacancy, Position position)
        {
            vacancy.Position = position;
            Update(vacancy);
        }

        public void SetRole(Vacancy vacancy, Grade role)
        {
        }

        public void SetSalary(Vacancy vacancy, int salary)
        {
            ArgumentOutOfRangeException.ThrowIfNegative(salary);
            vacancy.SuggestedSalary = salary;

        }

        public void SetDescription(Vacancy vacancy, string description)
        {
        }

        public void SetDescription(Vacancy vacancy, StringBuilder description)
        {
        }

    }
}
