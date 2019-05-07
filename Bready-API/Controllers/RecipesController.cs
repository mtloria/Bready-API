using System.Collections.Generic;
using BreadyAPI.DbContexts;
using BreadyAPI.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;

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
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {

            return Ok(_recipeService.GetRecipes());
        }
    }
}
