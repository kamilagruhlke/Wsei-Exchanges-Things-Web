using Microsoft.AspNetCore.Mvc;
using Wsei.Exchanges.Things.Web.Models;

namespace Wsei.Exchanges.Things.Web.Controllers
{
    public class ExchangesController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(ExchangesModel exchangesModel)
        {
            if(ModelState.IsValid == false)
            {
                return View();
            }

            return View(exchangesModel);
        }
    }
}
