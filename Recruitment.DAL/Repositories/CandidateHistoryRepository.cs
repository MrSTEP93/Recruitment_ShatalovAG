using Microsoft.EntityFrameworkCore;
using Recruitment.DAL.Models.People;
using Recruitment.DAL.Models.Recruitment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.DAL.Repositories
{
    public class CandidateHistoryRepository(AppDbContext db) : Repository<CandidateHistory>(db) 
    {
        public List<CandidateHistory> GetItemsByCandidate(Candidate candidate) 
        {
            Set.Include(c => c.Candidate);
            var result = Set.Where(x => x.Candidate == candidate).OrderByDescending(x => x.StartDate).ToList();
            return result ?? throw new NullReferenceException("Items not found");
        }

        public List<CandidateHistory> GetItemsByCandidateId(int candidateId)
        {
            Set.Include(c => c.Candidate);
            var result = Set.Where(x => x.Candidate.Id == candidateId).OrderByDescending(x => x.StartDate).ToList();
            return result ?? throw new NullReferenceException("Items not found");
        }

        public void AddItem(Candidate candidate, SelectionStage stage)
        {
            AddItem(candidate, stage, string.Empty);
        }

        public async void AddItem(Candidate candidate, SelectionStage stage, string comment)
        {
            CandidateHistory item = new()
            {
                Candidate = candidate,
                Stage = stage,
                StartDate = DateTime.Now,
                Comment = comment
            };
            await Create(item);
        }

        public void SetComment(CandidateHistory item, string newComment)
        {
        }

        public void SetDate(CandidateHistory item, DateTime date)
        {
        }
    }
}
