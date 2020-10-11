using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Wsei.Exchanges.Things.Web.Controllers
{
    public class ExchangesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
