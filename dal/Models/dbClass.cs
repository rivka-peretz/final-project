using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace dal.Models;

public partial class dbClass : DbContext
{
    public dbClass()
    {
    }

    public dbClass(DbContextOptions<dbClass> options)
        : base(options)
    {
    }

    public virtual DbSet<Project> Projects { get; set; }

    public virtual DbSet<Task> Tasks { get; set; }

    public virtual DbSet<Worker> Workers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='H:\\פרויקט סטאז\\TeamTaskManagement\\dal\\Data\\database.mdf';Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Project>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__projects__3214EC0706CBE1A7");

            entity.ToTable("projects");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.NameProject)
                .HasMaxLength(100)
                .IsFixedLength()
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("nameProject");
            entity.Property(e => e.SubmissionDate).HasColumnName("submission date");
        });

        modelBuilder.Entity<Task>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tasks__3214EC07E1230E86");

            entity.ToTable("tasks");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ProjectId).HasColumnName("projectId");
            entity.Property(e => e.SubmissionDate).HasColumnName("submission date");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .IsFixedLength()
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("title");

            entity.HasOne(d => d.Project).WithMany(p => p.Tasks)
                .HasForeignKey(d => d.ProjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tasks__projectId__4D94879B");
        });

        modelBuilder.Entity<Worker>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Workers__3214EC07F52D651E");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.TeamLeaderId).HasColumnName("bossId");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsFixedLength()
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsFixedLength()
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(10)
                .IsFixedLength()
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("password");
            entity.Property(e => e.StatusWorker)
                .HasMaxLength(10)
                .IsFixedLength()
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("statusWorker");
            entity.Property(e => e.TaskId).HasColumnName("taskId");

            entity.HasOne(d => d.TeamLeader).WithMany(p => p.Workers)
                .HasForeignKey(d => d.TeamLeaderId)
                .HasConstraintName("FK__Workers__bossId__5AEE82B9");

            entity.HasMany(d => d.Tasks).WithMany(p => p.Workers)
                .UsingEntity<Dictionary<string, object>>(
                    "WorkersTask",
                    r => r.HasOne<Task>().WithMany()
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Workers_T__task___5165187F"),
                    l => l.HasOne<Worker>().WithMany()
                        .HasForeignKey("WorkerId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Workers_T__worke__5070F446"),
                    j =>
                    {
                        j.HasKey("WorkerId", "TaskId").HasName("PK__Workers___16D9B5A68EC44F38");
                        j.ToTable("Workers_Tasks");
                        j.IndexerProperty<int>("WorkerId").HasColumnName("worker_Id");
                        j.IndexerProperty<int>("TaskId").HasColumnName("task_Id");
                    });
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
