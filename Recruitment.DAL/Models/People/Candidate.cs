using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Recruitment.DAL.Models.Recruitment;

namespace Recruitment.DAL.Models.People
{
    public class Candidate(string name, string email) : AbstractPerson(name, email)
    {
        public Vacancy? Vacancy { get; set; }
        public string ResumeURL { get; private set; } = string.Empty;
        public int ExpectedSalary { get; private set; } = 0;

        public void AddResume(string url)
        {
            ResumeURL = url;
        }
    }
}
