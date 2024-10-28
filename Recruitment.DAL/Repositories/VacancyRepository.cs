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

        public async void Add(string name, string description, int salary)
        {
            Vacancy vacancy = new(name)
            {
                Description = description,
            };
            await Create(vacancy);

            // в идеале, этот репо нужно получить из Dependecy Injection, но данный контейнер здесь не реализован
            var vacancyHistory = new VacancyHistoryRepository(db);
            vacancyHistory.InitFirstRecord(vacancy);

            SetSalary(vacancy, salary);
        }

        public void SetDepartment(Vacancy vacancy, Department department)
        {
        }

        public async void SetPosition(Vacancy vacancy, Position position)
        {
            vacancy.Position = position;
            await Update(vacancy);
        }

        public void SetLevel(Vacancy vacancy, Grade level)
        {
        }

        public async void SetSalary(Vacancy vacancy, int salary)
        {
            ArgumentOutOfRangeException.ThrowIfNegative(salary);
            vacancy.SuggestedSalary = salary;
            await Update(vacancy);
        }

        public void SetDescription(Vacancy vacancy, string description)
        {
        }

        public void SetDescription(Vacancy vacancy, StringBuilder description)
        {
        }

    }
}
