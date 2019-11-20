using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MyApplication.Models
{
    public partial class CRUDDBContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }

        public CRUDDBContext(DbContextOptions<CRUDDBContext> options)
            : base(options) 
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-7L1MEIHQ\SQLEXPRESS;Initial Catalog=CRUDDB;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //add to get identity to work so we dont get primary key errors.(Bud fix for the identity library)
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Departments>(entity =>
            {
                entity.Property(e => e.DeptId).ValueGeneratedNever();

                entity.Property(e => e.DeptName).IsUnicode(false);

                entity.Property(e => e.NoOfEmp).IsUnicode(false);

                entity.HasOne(d => d.Dept)
                    .WithOne(p => p.Departments)
                    .HasForeignKey<Departments>(d => d.DeptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Departmen__DeptI__1273C1CD");
            });

            modelBuilder.Entity<Employees>(entity =>
            {
                entity.Property(e => e.EmployeeId).ValueGeneratedNever();

                entity.Property(e => e.DeptId).IsUnicode(false);

                entity.Property(e => e.EmpName).IsUnicode(false);

                entity.Property(e => e.Position).IsUnicode(false);
            });
        }
    }
}
