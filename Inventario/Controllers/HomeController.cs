using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Inventario.Models;
using Microsoft.AspNetCore.Authorization;

namespace Inventario.Controllers
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
            ViewData["Title"] = "Inventario";
            return View();
        }

        public IActionResult About()
        {
            ViewData["Title"] = "EasyStock";
            ViewData["Subtitle"] = "Información de la apilcación";

            return View();
        }
        public IActionResult Manual()
        {
            ViewData["Title"] = "Manual de usuario";
            ViewData["Subtitle"] = "Información de la apilcación";

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
