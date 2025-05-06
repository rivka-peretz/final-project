using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bl.Services
{
    internal class ProjectBl
    {
        public int Id { get; set; }
        public string? NameProject { get; set; }
        public DateOnly SubmissionDate { get; set; }
    }
}
