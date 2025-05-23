using System;
using System.Collections.Generic;

namespace dal.Models;

public partial class Project
{
    public int Id { get; set; }

    public string? NameProject { get; set; }

    public DateOnly SubmissionDate { get; set; }

    public int TeamLeaderId { get; set; }

    public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();

    public virtual Worker TeamLeader { get; set; } = null!;
}
