using DrivingSchool.Repository.models;
using Microsoft.EntityFrameworkCore;

namespace DrivingSchool.Repository
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options)
            : base(options)
        {
        }
        public DbSet<Instructor>? Instructors { get; set; }
        public DbSet<Candidate>? Candidates { get; set; }
    }
}
