using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.DAL.Models.Recruitment
{
    /// <summary>
    /// Справочник статусов вакансии 
    /// (например, создана, отменена, закрыта)
    /// </summary>
    /// <param name="name"></param>
    public class VacancyStatus(string name)
    {
        public int Id { get; set; }

        public string Name { get; set; } = name;

        public string Description { get; set; } = string.Empty;
    }
}
