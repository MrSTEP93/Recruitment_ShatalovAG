using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.DAL.Models.Recruitment
{
    public class CandidateHistory(SelectionStage stage)
    {
        public int Id { get; set; }
        public SelectionStage Stage { get; set; } = stage;
        public DateTime StartDate { get; set; } = DateTime.Now;
        public string Comment { get; set; } = string.Empty;
    }
}
