using Microsoft.AspNetCore.Mvc;
using NXTLesson02Theory.Models;
namespace NXTLesson02Theory.Controllers
{
    public class NXTProductController : Controller
    {
        public IActionResult NXTindex()
        {
            ViewBag.name = "Nguyễn Xuân Trường ";
            ViewData["productNXT"] = "Laptop MSI";
            TempData["UNI"] = "Trường Đại học Nguyễn Trãi - NTU ";
            return View();
        }
        public IActionResult GetProduct()
        {
            NxtProduct NxtProduct = new NxtProduct()

            {
                ProductID = "2410900081",
                ProductName = "Nguyễn Xuân Trường",
                YearRelease = 1979,
                Price = 99999999999999,

            };

            ViewBag.product = NxtProduct;
            ViewData["product"] = NxtProduct;
            return View("Product");
        }
    }
}
