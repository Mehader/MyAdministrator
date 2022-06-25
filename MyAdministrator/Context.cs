using Microsoft.EntityFrameworkCore;
using MyAdministrator.Models;
using System.Configuration;

namespace MyAdministrator
{
    public class Context : DbContext
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["SQLlite"].ConnectionString;

        public DbSet<Administrator> Administrators => Set<Administrator>();
        public DbSet<Student> Students => Set<Student>();
        public DbSet<Subject> Subjects => Set<Subject>();
        public DbSet<History> History => Set<History>();
        public DbSet<StudentSubject> StudentsSubjects => Set<StudentSubject>();
        
        public Context()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(connectionString);
        }
    }
}
