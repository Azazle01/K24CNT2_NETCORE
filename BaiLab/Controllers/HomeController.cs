using BaiLab.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Collections.Generic;
namespace BaiLab.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var latestProducts = new List<Product>
            {
                new Product { Id = 1, Name = "Nồi cơm điện cao tần Nagakawa NAG0102", ImageUrl = "/images/noicom.jpg", Price = 2500000 },
                new Product { Id = 2, Name = "Nồi cơm điện cao tần Nagakawa NAG0102", ImageUrl = "/images/noicom.jpg", Price = 2500000 },
                new Product { Id = 3, Name = "Nồi cơm điện cao tần Nagakawa NAG0102", ImageUrl = "/images/noicom.jpg", Price = 2500000 }
            };

            
            var categories = new List<Category>
            {
                new Category { Id = 1, Name = "Áo dài" },
                new Category { Id = 2, Name = "Áo đông" },
                new Category { Id = 3, Name = "Túi xách" },
                new Category { Id = 4, Name = "Đồng hồ" },
                new Category { Id = 5, Name = "Ví da" },
                new Category { Id = 6, Name = "Thắt lưng da" },
                new Category { Id = 7, Name = "Tủ lạnh" },
                new Category { Id = 8, Name = "Tivi" },
                new Category { Id = 9, Name = "Quạt điện" },
                new Category { Id = 10, Name = "Lò sưởi" }
            };

            
            ViewBag.Categories = categories;

            
            return View(latestProducts);
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
