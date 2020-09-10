using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VueDemo.Models;

namespace VueDemo.Controllers
{
    [EnableCors("any")]
    [Route("/[Controller]/[Action]")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [ResponseCache(Duration = 600)]
        public IActionResult Home()
        {
            return View();
        }
        [ResponseCache(Duration = 600)]
        public IActionResult GetNavs()
        {
            return new JsonResult(TypeViewModel.ListAll());
        }
        [ResponseCache(Duration = 600)]
        public IActionResult GetMarketList()
        {
            return new JsonResult(ListViewModel.ListAll());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
