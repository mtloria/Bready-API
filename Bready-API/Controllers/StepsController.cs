using BreadyAPI.DbContexts;
using BreadyAPI.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using System.Linq;

namespace Bready_API.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("AllowOrigin")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        private readonly RecipeData _recipeService;

        public RecipesController(RecipeDbContext context)
        {
            _recipeService = new RecipeData(context);
        }

        // GET api/recipes
        [HttpGet("{breadId}")]
        public ActionResult<string> Get(int breadId)
        {

            return Ok(_recipeService.GetRecipeByBreadId(breadId));
        }
    }
}
