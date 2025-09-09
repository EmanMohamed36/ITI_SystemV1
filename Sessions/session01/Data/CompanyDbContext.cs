using Microsoft.EntityFrameworkCore;
using session01.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session01.Data
{
    internal class CompanyDbContext:DbContext
    {
        public CompanyDbContext() : base()
        { 
        
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
        //    optionsBuilder.UseSqlServer("Data Source=DESKTOP-V690Q3O;Initial Catalog=Company;Integrated Security=True");//old connection
            optionsBuilder.UseSqlServer("Server=DESKTOP-V690Q3O; Database=Company;Trusted_Connection=True; TrustServerCertificate=True");//new connection
             
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasOne(s => s.Department)
                .WithMany(d => d.Students)
                .HasForeignKey(s => s.Dep_Id);

            modelBuilder.Entity<Course>()
                .HasOne(c => c.Topic)
                .WithMany(t => t.Courses)
                .HasForeignKey(c => c.Top_ID);

            modelBuilder.Entity<Stud_Course>()
                .HasKey(sc => new { sc.stud_ID, sc.Course_ID });

            modelBuilder.Entity<Stud_Course>()
                .HasOne(sc => sc.Student)
                .WithMany(s => s.stud_Courses)
                .HasForeignKey(sc => sc.stud_ID);

            modelBuilder.Entity<Stud_Course>()
                .HasOne(sc => sc.Course)
                .WithMany(c => c.stud_Courses)
                .HasForeignKey(sc => sc.Course_ID);

            modelBuilder.Entity<Department>()
                .HasOne(d => d.Instructor)
                .WithOne()
                .HasForeignKey<Department>(d => d.Ins_ID);

            modelBuilder.Entity<Instructor>()
                .HasOne(i => i.Department)
                .WithMany(d => d.Instructors)
                .HasForeignKey(i => i.Dept_ID);

            modelBuilder.Entity<Course_Inst>()
                .HasKey(ci => new { ci.inst_ID, ci.Course_ID});

            modelBuilder.Entity<Course_Inst>()
                .HasOne(ci => ci.Instructor)
                .WithMany(i => i.Course_Instructors)
                .HasForeignKey(ci => ci.inst_ID);

            modelBuilder.Entity<Course_Inst>()
                .HasOne(ci => ci.Course)
                .WithMany(c => c.Course_Instructors)
                .HasForeignKey(ci => ci.Course_ID);
        }


    }
}
