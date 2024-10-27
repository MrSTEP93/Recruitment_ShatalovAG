using Microsoft.EntityFrameworkCore;
using Recruitment.DAL.Models.Recruitment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.DAL.Repositories
{
    public class VacancyStatusRepository(AppDbContext db) : Repository<VacancyStatus>(db)
    {
        public async Task<VacancyStatus> GetByName(string name)
        {
            var result = await Set.FirstOrDefaultAsync(p => p.Name.Contains(name, StringComparison.CurrentCultureIgnoreCase));
            if (result is not null)
            {
                return result!;
            } else
            {
                throw new NullReferenceException("Entry not found");
            }
        }

        public void SetDescription(VacancyStatus item, string description)
        {
            item.Description = description;
            Update(item);
        }
    }
}
