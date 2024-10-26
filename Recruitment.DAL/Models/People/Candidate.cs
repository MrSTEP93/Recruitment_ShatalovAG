using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Recruitment.DAL.Models.Recruitment;

namespace Recruitment.DAL.Models.People
{
    public class Candidate(string name, string resumeURL, string email, int expectedSalary) : AbstractPerson(name, email)
    {
        public Candidate(string name, string email) : this(name, string.Empty, email, 0) { }

        public Vacancy? Vacancy { get; set; }
        public string ResumeURL { get; private set; } = resumeURL;
        public int ExpectedSalary { get; private set; } = expectedSalary;

        /*
        public void AddResume(string url)
        {
            ResumeURL = url;
        }
        */
    }
}
