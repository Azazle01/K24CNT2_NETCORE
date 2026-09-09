using Microsoft.AspNetCore.Mvc;

namespace NXTLesson06.ViewComponents
{
    public class CategoryViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(int? n)
        {
            var categories = new List<Models.Category>
            {
                new Models.Category {CategoryId=1,CategoryName= "Electronic",Isactive=true},
                new Models.Category {CategoryId=2,CategoryName= "Books",Isactive=true},
                new Models.Category {CategoryId=3,CategoryName= "Clothing",Isactive=false},
                new Models.Category {CategoryId=4,CategoryName= "Home & Kitchen ",Isactive=true},
            };
            n = n ?? 0;
            var search = categories.Where(c => c.CategoryId>n).ToList();
            return View(search);
        }
    }
}
