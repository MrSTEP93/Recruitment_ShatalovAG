using Microsoft.EntityFrameworkCore;
using Recruitment.DAL.Models.Recruitment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.DAL.Repositories
{
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
            AddNewRecord(vacancy, status, "Vacancy created");
            
        }

        public void AddNewRecord(Vacancy vacancy, VacancyStatus status)
        {
            AddNewRecord(vacancy, status, string.Empty);
        }

        public void AddNewRecord(Vacancy vacancy, VacancyStatus status, string comment)
        {
            var historyRecord = new VacancyHistory()
            {
                Vanancy = vacancy,
                Status = status,
                Date = DateTime.Now,
                Comment = comment
            };
            Create(historyRecord);
        }

        public void SetComment(VacancyHistory item, string newComment)
        {
            item.Comment = newComment;
            Update(item);
        }

        public void SetDate(VacancyHistory item, DateTime date) 
        {
        }
    }
}
