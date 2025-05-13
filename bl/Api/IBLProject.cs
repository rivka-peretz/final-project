using bl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bl.Api
{
    internal interface IBLProject
    {
        public int Id { get; set; }

        public string? NameProject { get; set; }

        public DateOnly SubmissionDate { get; set; }

        public List<BLTask> Tasks { get; set; }
    }
}
