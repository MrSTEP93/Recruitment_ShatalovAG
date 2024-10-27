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
        public void AddStage(string name)
        {
            AddStage(name, string.Empty);
        }

        public void AddStage(string name, string description)
        {
            SelectionStage stage = new(name)
            {
                Description = description
            };

            Create(stage);
        }

        public void SetDescription(SelectionStage item, string newDescription)
        {
        }
    }
}
