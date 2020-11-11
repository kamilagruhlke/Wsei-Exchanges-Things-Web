using Microsoft.AspNetCore.Mvc;

namespace Wsei.Exchanges.Things.Web.Controllers
{
    public class ExchangesController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
