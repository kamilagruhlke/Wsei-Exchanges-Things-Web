using Microsoft.AspNetCore.Mvc;
using Wsei.Exchanges.Things.Web.Models;

namespace Wsei.Exchanges.Things.Web.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExchangesController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] ExchangesModel exchangesModel)
        {
            if (ModelState.IsValid == false)
            {
                return BadRequest();
            }

            return Ok(new { success = true });
        }
    }
}
