using BreadyAPI.DbContexts;
using BreadyAPI.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;

namespace Bready_API.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("AllowOrigin")]
    [ApiController]
    public class StepsController : ControllerBase
    {
        private readonly StepData _stepService;

        public StepsController(StepDbContext context)
        {
            _stepService = new StepData(context);
        }

        // GET api/steps/recipeId/stepNumber
        [HttpGet("{recipeId}/{stepNumber}")]
        public ActionResult<string> Get(int recipeId, int stepNumber)
        {

            return Ok(_stepService.GetStepByNumberAndRecipeId(recipeId, stepNumber));
        }
    }
}
