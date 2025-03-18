using System;
using System.Collections.Generic;

namespace TeamTaskManagement.models;

public partial class Project
{
    public int Id { get; set; }

    public string? NameProject { get; set; }

    public DateOnly SubmissionDate { get; set; }

    public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();
}
