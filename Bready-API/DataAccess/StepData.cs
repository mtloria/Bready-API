using BreadyAPI.DbContexts;
using BreadyAPI.Models;
using System.Linq;

namespace BreadyAPI.DataAccess
{
    public class StepData
    {
        private readonly StepDbContext _context;

        public StepData(StepDbContext context)
        {
            _context = context;
        }

        public Step GetStepByNumberAndRecipeId(int recipeId, int stepNumber)
        {
            var stepEntity = _context.Steps.FirstOrDefault(step => step.RecipeId == recipeId && step.StepNumber == stepNumber);
            return new Step(stepEntity);
        }
    }
}
