using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace sss
{
    public partial class ITIDBContext : DbContext
    {
        public ITIDBContext()
            : base("name=ITIDBContext")
        {
        }

        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<dailyt> dailyts { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Ins_Course> Ins_Course { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<lastt> lastts { get; set; }
        public virtual DbSet<Stud_Course> Stud_Course { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Topic> Topics { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>()
                .HasMany(e => e.Ins_Course)
                .WithRequired(e => e.Course)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.Stud_Course)
                .WithRequired(e => e.Course)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Department>()
                .HasMany(e => e.Instructors)
                .WithOptional(e => e.Department)
                .HasForeignKey(e => e.Dept_Id);

            modelBuilder.Entity<Instructor>()
                .Property(e => e.Salary)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Instructor>()
                .HasMany(e => e.Departments)
                .WithOptional(e => e.Instructor)
                .HasForeignKey(e => e.Dept_Manager);

            modelBuilder.Entity<Instructor>()
                .HasMany(e => e.Ins_Course)
                .WithRequired(e => e.Instructor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.St_Lname)
                .IsFixedLength();

            modelBuilder.Entity<Student>()
                .HasMany(e => e.Stud_Course)
                .WithRequired(e => e.Student)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.Student1)
                .WithOptional(e => e.Student2)
                .HasForeignKey(e => e.St_super);
        }
    }
}
