using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bl.Api
{
    internal interface IBLTask
    {
        public int Id { get; set; }

        public string? Title { get; set; }

        public int ProjectId { get; set; }

        public DateOnly SubmissionDate { get; set; }
    }
}
