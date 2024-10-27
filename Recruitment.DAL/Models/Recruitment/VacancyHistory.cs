using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.DAL.Models.Recruitment
{
    public class VacancyHistory
    {
        public int Id { get; set; }
        public Vacancy Vanancy { get; internal set; }
        public VacancyStatus Status { get; internal set; }
        public DateTime Date { get; internal set; } = DateTime.Now;
        public string Comment { get; internal set; } = string.Empty;
    }
}
