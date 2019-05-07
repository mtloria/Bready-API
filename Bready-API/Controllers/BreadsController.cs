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
    public class BreadsController : ControllerBase
    {
        private readonly BreadData _breadService;

        public BreadsController(BreadDbContext context)
        {
            _breadService = new BreadData(context);
        }

        // GET api/breads
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {

            return Ok(_breadService.GetBreads());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
