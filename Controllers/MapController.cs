using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Novacyt.Controllers
{
    public class MapController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult GetLocations()
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
    }
}

