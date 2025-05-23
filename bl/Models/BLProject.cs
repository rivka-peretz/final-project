using bl.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bl.Models
{
    public class BLProject 
    {
        public int Id { get; set; }

        public string? NameProject { get; set; }

        public DateOnly SubmissionDate { get; set; }
        public List<BLTask> Tasks { get; set; }
        public BLProject(int id, string name, DateOnly submissionDate)
        {
            Id = id;
            NameProject = name;
            SubmissionDate = submissionDate;
        }


    }
}
