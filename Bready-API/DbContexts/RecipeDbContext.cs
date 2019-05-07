using BreadyAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace BreadyAPI.DbContexts
{
    public class RecipeDbContext : DbContext
    {
        public DbSet<RecipeEntity> Recipes { get; set; }

        public RecipeDbContext(DbContextOptions<RecipeDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public RecipeDbContext()
        {
        }
    }
}
