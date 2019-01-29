using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using customertest.Models;
using Microsoft.Extensions.Logging;

namespace customertest.Controllers
{
    public class HomeController : Controller
    {
        private IEurekaClientService _eurekaClientService;
        private ILogger<HomeController> _logger;


        public HomeController(IEurekaClientService eurekaClientService, ILogger<HomeController> logger)
        {
            _eurekaClientService = eurekaClientService;
            _logger = logger;
        }

        public IActionResult Index()
        {
            string aaaaaa=_eurekaClientService.GetTestAsync("api/values").GetAwaiter().GetResult();
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
