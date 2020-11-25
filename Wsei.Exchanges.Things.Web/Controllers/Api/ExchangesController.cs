using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System.Threading.Tasks;
using Wsei.Exchanges.Things.Web.Database;
using Wsei.Exchanges.Things.Web.Entities;
using Wsei.Exchanges.Things.Web.Models;

namespace Wsei.Exchanges.Things.Web.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExchangesController : ControllerBase
    {

        private readonly ExchangesDbContext _dbContext;

        public ExchangesController(ExchangesDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ExchangesModel exchangesModel, CancellationToken cancellationToken)
        {
            if (ModelState.IsValid == false)
            {
                return BadRequest();
            }

            var entity = new ItemEntity
            {
                Name = exchangesModel.Name,
                Description = exchangesModel.Description,
                IsVisible = exchangesModel.IsVisible
            };

            await _dbContext.Items.AddAsync(entity, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return Ok(new { success = true });
        }
    }
}
