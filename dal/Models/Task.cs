using System;
using System.Collections.Generic;

namespace bl.Models;

public partial class Task
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public int ProjectId { get; set; }

    public DateOnly SubmissionDate { get; set; }

    public virtual Project Project { get; set; } = null!;

    public virtual ICollection<Worker> Workers { get; set; } = new List<Worker>();
}
