using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace StudentCrud.Models
{
    public partial class MydbContext : DbContext
    {
        public MydbContext()
        {
        }

        public MydbContext(DbContextOptions<MydbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Student> Students { get; set; }

        // OnConfiguring is optional if using JSON-based connection strings
        // Remove override if you configure via DI in Startup.cs / Program.cs

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.StudentId)
                      .HasName("PK__Students__32C52B99FB121088");

                entity.Property(e => e.CreatedAt)
                      .HasDefaultValueSql("(getdate())")
                      .HasColumnType("datetime");

                entity.Property(e => e.FatherName)
                      .HasMaxLength(100);

                entity.Property(e => e.StudentGender)
                      .HasMaxLength(1)
                      .IsUnicode(false)
                      .IsFixedLength();

                entity.Property(e => e.StudentName)
                      .HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
