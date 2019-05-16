using BreadyAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace BreadyAPI.DbContexts
{
    public class StepDbContext : DbContext
    {
        public DbSet<StepEntity> Steps { get; set; }

        public StepDbContext(DbContextOptions<StepDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public StepDbContext()
        {
        }
    }
}
