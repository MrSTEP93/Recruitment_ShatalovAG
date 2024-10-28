using Microsoft.EntityFrameworkCore;
using Recruitment.DAL.Models.Recruitment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.DAL.Repositories
{
    /// <summary>
    /// Репозиторий для работы с историей вакансии
    /// </summary>
    /// <param name="db">Контекст бд</param>
    public class VacancyHistoryRepository(AppDbContext db) : Repository<VacancyHistory>(db)
    {
        public void InitFirstRecord(Vacancy vacancy)
        {
            // в идеале, этот репо нужно получить из Dependecy Injection, но данный контейнер здесь не реализован
            var vacancyStatusRepo = new VacancyStatusRepository(db);
            VacancyStatus status;
            try
            {
                status = vacancyStatusRepo.GetByName("create").Result;
            }
            catch (NullReferenceException)
            {
                status = vacancyStatusRepo.GetByName("создан").Result;
            }
            AddNewItem(vacancy, status, "Vacancy created");
            
        }

        public void AddNewItem(Vacancy vacancy, VacancyStatus status)
        {
            AddNewItem(vacancy, status, string.Empty);
        }

        public async void AddNewItem(Vacancy vacancy, VacancyStatus status, string comment)
        {
            var historyRecord = new VacancyHistory()
            {
                Vanancy = vacancy,
                Status = status,
                Date = DateTime.Now,
                Comment = comment
            };
            await Create(historyRecord);
        }

        public async void SetComment(VacancyHistory item, string newComment)
        {
            item.Comment = newComment;
            await Update(item);
        }

        public void SetDate(VacancyHistory item, DateTime date) 
        {
        }

        public List<VacancyHistory> GetStoryOfVacancy(Vacancy vacancy)
        {
            return [];
        }

        public List<VacancyHistory> GetStoryOfVacancyId(int vacancyId)
        {
            return [];
        }
    }
}
