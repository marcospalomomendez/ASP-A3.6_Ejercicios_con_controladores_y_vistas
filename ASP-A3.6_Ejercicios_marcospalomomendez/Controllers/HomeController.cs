using System.Diagnostics;
using ASP_A3._6_Ejercicios_marcospalomomendez.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_A3._6_Ejercicios_marcospalomomendez.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
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
