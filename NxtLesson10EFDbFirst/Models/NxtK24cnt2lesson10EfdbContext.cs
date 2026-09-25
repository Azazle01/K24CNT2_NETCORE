using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NxtLesson10EFDbFirst.Models;

public partial class NxtK24cnt2lesson10EfdbContext : DbContext
{
    public NxtK24cnt2lesson10EfdbContext()
    {
    }

    public NxtK24cnt2lesson10EfdbContext(DbContextOptions<NxtK24cnt2lesson10EfdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<NxtMember> NxtMembers { get; set; }

 //   protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=MSI\\SQLEXPRESS;Database=NxtK24CNT2Lesson10EFDb;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<NxtMember>(entity =>
        {
            entity.ToTable("NxtMember");

            entity.Property(e => e.NxtEmail)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NxtFullName).HasMaxLength(50);
            entity.Property(e => e.NxtPassword)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NxtPhone)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.NxtUserName)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
