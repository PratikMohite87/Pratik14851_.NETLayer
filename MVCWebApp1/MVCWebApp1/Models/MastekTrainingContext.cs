using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace MVCWebApp1.Models
{
    public partial class MastekTrainingContext : DbContext
    {
        public MastekTrainingContext()
        {
        }

        public MastekTrainingContext(DbContextOptions<MastekTrainingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Dept> Depts { get; set; }
        public virtual DbSet<Emp> Emps { get; set; }
        public virtual DbSet<Userdatum> Userdata { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB; database=MastekTraining;  Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Dept>(entity =>
            {
                entity.HasKey(e => e.Deptno)
                    .HasName("DEPT_deptno_pk1");

                entity.ToTable("DEPT");

                entity.HasIndex(e => e.Dname, "DEPT_Dname_UNQ")
                    .IsUnique();

                entity.Property(e => e.Deptno)
                    .ValueGeneratedNever()
                    .HasColumnName("DEPTNO");

                entity.Property(e => e.Dname)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("DNAME");

                entity.Property(e => e.Loc)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("LOC");
            });

            modelBuilder.Entity<Emp>(entity =>
            {
                entity.HasKey(e => e.Empno)
                    .HasName("EMP_EMPNO_PK");

                entity.ToTable("EMP");

                entity.Property(e => e.Empno)
                    .ValueGeneratedNever()
                    .HasColumnName("EMPNO");

                entity.Property(e => e.Comm)
                    .HasColumnType("numeric(7, 2)")
                    .HasColumnName("COMM");

                entity.Property(e => e.Deptno).HasColumnName("DEPTNO");

                entity.Property(e => e.Ename)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ENAME");

                entity.Property(e => e.Hiredate)
                    .HasColumnType("datetime")
                    .HasColumnName("HIREDATE");

                entity.Property(e => e.Job)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("JOB");

                entity.Property(e => e.Mgr).HasColumnName("MGR");

                entity.Property(e => e.Sal)
                    .HasColumnType("numeric(7, 2)")
                    .HasColumnName("SAL");

                entity.HasOne(d => d.DeptnoNavigation)
                    .WithMany(p => p.Emps)
                    .HasForeignKey(d => d.Deptno)
                    .HasConstraintName("EMP_DEPTNO_FK");

                entity.HasOne(d => d.MgrNavigation)
                    .WithMany(p => p.InverseMgrNavigation)
                    .HasForeignKey(d => d.Mgr)
                    .HasConstraintName("EMP_MGR_SK");
            });

            modelBuilder.Entity<Userdatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("userdata");

                entity.Property(e => e.Username)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("username");

                entity.Property(e => e.Userpassword)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("userpassword");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
