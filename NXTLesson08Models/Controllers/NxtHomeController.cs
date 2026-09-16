using Microsoft.AspNetCore.Mvc;
using NXTLesson08Models.Models;
using System.Diagnostics;

namespace NXTLesson08Models.Controllers
{
    public class NxtHomeController : Controller
    {
        private readonly ILogger<NxtHomeController> _logger;

        public NxtHomeController(ILogger<NxtHomeController> logger)
        {
            _logger= logger;
        }
        public IActionResult NxtIndex()
        {
            return View();
        }

        public IActionResult NxtPrivacy()
        {
            return View();
        }

        public IActionResult NxtAbout()
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
