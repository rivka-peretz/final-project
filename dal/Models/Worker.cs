using System;
using System.Collections.Generic;

namespace bl.Models;

public partial class Worker
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int TaskId { get; set; }

    public string Email { get; set; } = null!;

    public string StatusWorker { get; set; } = null!;

    public int? TeamLeaderId { get; set; }

    public virtual Worker? TeamLeader { get; set; }

    public virtual ICollection<Worker> Workers { get; set; } = new List<Worker>();

    public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();
}
