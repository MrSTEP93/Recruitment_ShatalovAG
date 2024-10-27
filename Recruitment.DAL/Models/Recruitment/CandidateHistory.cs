using Recruitment.DAL.Models.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.DAL.Models.Recruitment
{
    public class CandidateHistory()
    {
        public int Id { get; internal set; }
        public Candidate Candidate { get; internal set; }
        public SelectionStage Stage { get; internal set; }
        public DateTime StartDate { get; internal set; } = DateTime.Now;
        public string Comment { get; internal set; } = string.Empty;
    }
}
