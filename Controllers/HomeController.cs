using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Novacyt.Models;

namespace Novacyt.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetLocations()
        {

            var locations = new List<Models.Locations>()
            {
                new Models.Locations("france",12.505353,55.335292),
                 new Models.Locations("london",13.505353,55.485292),
                  new Models.Locations("italy",13.655353,55.665292)
            };

            using StreamReader r = new StreamReader("locations.json");
            string json = r.ReadToEnd();
            return Json(json);

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

