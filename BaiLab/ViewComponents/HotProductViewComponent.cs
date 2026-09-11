using BaiLab.Models;
using Microsoft.AspNetCore.Mvc;

namespace BaiLab.ViewComponents
{
    public class HotProductViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            var hotProducts = new List<Product>
            {
                new Product { Id = 4, Name = "Nồi cơm điện cao tần Nagakawa NAG0102", ImageUrl = "/images/noicom.jpg", Price = 2500000 },
                new Product { Id = 5, Name = "Nồi cơm điện cao tần Nagakawa NAG0102", ImageUrl = "/images/noicom2.jpg", Price = 2500000 },
                new Product { Id = 6, Name = "Nồi cơm điện cao tần Nagakawa NAG0102", ImageUrl = "/images/noicom3.jpg", Price = 2500000 }
            };
            return View(hotProducts);
        }
    }
}