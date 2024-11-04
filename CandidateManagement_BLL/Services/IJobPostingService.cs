using CandidateManagement_DAL.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateManagement_BLL.Services
{
    public interface IJobPostingService
    {
        public ArrayList GetAllJobPostings();
        public bool AddJobPosting(JobPosting posting);
        public bool UpdateJobPosting(JobPosting posting);
        public bool DeleteJobPosting(string postingId);
        public ArrayList GetJobPostingByTitleOrPostDate(string? Title, DateTime? Date);
        public JobPosting GetJobPostingById(string id);
    }
}
