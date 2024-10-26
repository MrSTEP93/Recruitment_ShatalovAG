using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.DAL.Models.Recruitment
{
    public class VanancyHistory(Vacancy vacancy, VacancyStatus status)
    {
        public int Id { get; set; }
        public Vacancy Vanancy { get; set; } = vacancy;
        public VacancyStatus Status { get; set; } = status;
        public DateTime Date { get; set; } = DateTime.Now;
        public string Comment { get; set; } = string.Empty;
    }
}
