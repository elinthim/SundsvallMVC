using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Testinmvc.Models;

namespace Testinmvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult CV()
        {
            return View();
        }

    }
}