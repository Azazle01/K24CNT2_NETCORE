using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NguyenXuanTruong2410900081_exam.Models;

public partial class NxtEmployeeContext : DbContext
{
    public NxtEmployeeContext()
    {
    }

    public NxtEmployeeContext(DbContextOptions<NxtEmployeeContext> options)
        : base(options)
    {
    }

    public virtual DbSet<NxtEmployee> NxtEmployees { get; set; }

 //   protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
  //      => optionsBuilder.UseSqlServer("Server=MSI\\SQLEXPRESS;Database=Nxt Employee;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<NxtEmployee>(entity =>
        {
            entity.ToTable("NxtEmployee");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.NxtEmail)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NxtName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.NxtPhone)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
