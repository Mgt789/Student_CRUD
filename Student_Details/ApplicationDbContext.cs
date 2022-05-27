using Microsoft.EntityFrameworkCore;
using Student_Details.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student_Details
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }

        public DbSet<Enrolment> enrolments { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<Course> courses { get; set; }
        public DbSet<courseAssignment> courseAssignments { get; set; }
        public DbSet<officeAssignment> officeAssignment { get; set; }
        public DbSet<Instructor> instructors { get; set; }


    }
}
