using Microsoft.AspNetCore.Mvc;
using NXTlesson01Mvc.Models;
using System.Diagnostics;

namespace NXTlesson01Mvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.name = "Nguyễn Xuân Trường";
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
