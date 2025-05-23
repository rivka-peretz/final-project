using System;
using System.Collections.Generic;

namespace dal.Models;

public partial class Worker
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string StatusWorker { get; set; } = null!;

    public int? BossId { get; set; }

    public virtual Worker? Boss { get; set; }

    public virtual ICollection<Worker> InverseBoss { get; set; } = new List<Worker>();

    public virtual ICollection<Project> Projects { get; set; } = new List<Project>();

    public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();
}
