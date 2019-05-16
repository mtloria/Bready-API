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

        public Recipe GetRecipeByBreadId(int breadId)
        {
            //ToDo: some breads will have multiple recipes, so we will have to handle this at some point
            var recipeEntity = _context.Recipes.FirstOrDefault(recipe => recipe.BreadId == breadId);
            return new Recipe(recipeEntity);
        }
    }
}
