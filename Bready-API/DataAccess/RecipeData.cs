using System.Collections.Generic;
using System.Linq;
using BreadyAPI.DbContexts;
using BreadyAPI.Models;

namespace BreadyAPI.DataAccess
{
    public class RecipeData
    {
        private readonly RecipeDbContext _context;

        public RecipeData(RecipeDbContext context)
        {
            _context = context;
        }

        public List<Recipe> GetRecipes()
        {
            var recipeEntities = _context.Recipes;
            return recipeEntities.Select(recipeEntity => new Recipe(recipeEntity)).ToList();
        }
    }
}
