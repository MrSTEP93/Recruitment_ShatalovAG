using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.DAL.Models
{
    public class Candidate : AbstractPerson
    {
        public Candidate(string name, string email) : this (name, string.Empty, email, 0) { }

        public Candidate(string name, string resumeURL, string email, int expectedSalary) : base(name, email) 
        {
            ResumeURL = resumeURL;
            ExpectedSalary = expectedSalary;
        }

        public string ResumeURL { get; private set; }

        public int ExpectedSalary { get; private set; }

        /*
        public void AddResume(string url)
        {
            ResumeURL = url;
        }
        */
    }
}
