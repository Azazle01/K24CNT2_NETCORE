using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using NXTLesson03.Models;
namespace NXTLesson03.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("/danh-sach-san-pham")]
    public class NxtProductController : Controller
    {
        private readonly List<NxtProduct> _products = new()
        { 
            new NxtProduct { NxtProductID = "MOB-001", NxtProductName = "iPhone 15 Pro Max", NxtYearRealease = 2023, NxtPrice = 1199.99m },
    new NxtProduct { NxtProductID = "MOB-002", NxtProductName = "Samsung Galaxy S24 Ultra", NxtYearRealease = 2024, NxtPrice = 1299.99m },
    new NxtProduct { NxtProductID = "MOB-003", NxtProductName = "Google Pixel 8 Pro", NxtYearRealease = 2023, NxtPrice = 999.00m },
    new NxtProduct { NxtProductID = "MOB-004", NxtProductName = "Xiaomi 14 Ultra", NxtYearRealease = 2024, NxtPrice = 1099.50m },
    new NxtProduct { NxtProductID = "MOB-005", NxtProductName = "iPad Pro M4 13-inch", NxtYearRealease = 2024, NxtPrice = 1299.00m },
    new NxtProduct { NxtProductID = "MOB-006", NxtProductName = "Samsung Galaxy Tab S9 Ultra", NxtYearRealease = 2023, NxtPrice = 1199.00m },
    new NxtProduct { NxtProductID = "MOB-007", NxtProductName = "Apple Watch Series 9", NxtYearRealease = 2023, NxtPrice = 399.00m },
    new NxtProduct { NxtProductID = "MOB-008", NxtProductName = "Samsung Galaxy Watch 6 Classic", NxtYearRealease = 2023, NxtPrice = 399.99m },
    new NxtProduct { NxtProductID = "MOB-009", NxtProductName = "OnePlus 12", NxtYearRealease = 2024, NxtPrice = 799.99m },
    new NxtProduct { NxtProductID = "MOB-010", NxtProductName = "Sony Xperia 1 VI", NxtYearRealease = 2024, NxtPrice = 1399.00m }

    };
        
        public IActionResult Index()
        {
            return Json (_products);
        }
        [Microsoft.AspNetCore.Mvc.Route("/all")]
        public IActionResult NxtGetProduct()
        {
            ViewData["products"] = _products;
            return View();
                }
    }
}
