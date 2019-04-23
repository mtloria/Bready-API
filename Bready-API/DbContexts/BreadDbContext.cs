using BreadyAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace BreadyAPI.DbContexts
{
    public class BreadDbContext : DbContext
    {
        public DbSet<BreadEntity> Breads { get; set; }

        public BreadDbContext(DbContextOptions<BreadDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public BreadDbContext()
        {
        }
    }
}
