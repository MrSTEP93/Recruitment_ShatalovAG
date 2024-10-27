using Recruitment.DAL.Models.Recruitment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.DAL.Repositories
{
    public class SelectionStageRepository(AppDbContext db) : Repository<SelectionStage>(db)
    {
        public async void AddStage(string name)
        {
            await AddStage(name, string.Empty);
        }

        public async Task AddStage(string name, string description)
        {
            SelectionStage stage = new(name)
            {
                Description = description
            };

            await Create(stage);
        }

        public async Task SetDescription(SelectionStage item, string newDescription)
        {
            item.Description = newDescription;
            await Update(item);
        }
    }
}
