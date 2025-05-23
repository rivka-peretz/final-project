using System;
using System.Collections.Generic;

namespace dal.Models;

public partial class Task
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public int ProjectId { get; set; }

    public DateOnly SubmissionDate { get; set; }

    public int WorkerId { get; set; }

    public virtual Project Project { get; set; } = null!;

    public virtual Worker Worker { get; set; } = null!;
}
