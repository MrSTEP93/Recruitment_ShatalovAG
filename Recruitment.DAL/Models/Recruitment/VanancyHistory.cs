using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.DAL.Models.Recruitment
{
    public class VanancyHistory
    {
        public int Id { get; set; }
        public Vacancy Vanancy { get; set; }
        public VacancyStatus Status { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public string Comment { get; set; } = string.Empty;
    }
}
