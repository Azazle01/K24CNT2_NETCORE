using Microsoft.AspNetCore.Mvc;
using NXTLesson07Models.Models.DataModel;
namespace NXTLesson07Models.Controllers
{
    public class NxtMemberController : Controller
    {
        protected List<NxtMember> _members = new List<NxtMember>
        {
            
        new NxtMember
        {
           NxtMemberId = Guid.NewGuid().ToString(),
            NxtUserName = "AzTV",
            NxtPassword = "1223456",
            NxtFullName = "Nguyễn Xuân Trường",
            NxtEmail = "nimion@gmail.com"
        },

        new NxtMember
        {
            NxtMemberId = Guid.NewGuid().ToString(),
            NxtUserName = "tranthib",
            NxtPassword = "1923456",
            NxtFullName = "Trần Thị Bình",
            NxtEmail = "tranthib@gmail.com"
        },

        new NxtMember
        {
           NxtMemberId = Guid.NewGuid().ToString(),
            NxtUserName = "levanc",
            NxtPassword = "1234056",
            NxtFullName = "Lê Văn Cường",
            NxtEmail = "levanc@gmail.com"
        },

        new NxtMember
        {
            NxtMemberId = Guid.NewGuid().ToString(),
            NxtUserName = "phamthid",
            NxtPassword = "1234456",
            NxtFullName = "Phạm Thị Dung",
            NxtEmail = "phamthid@gmail.com"
        },

        new NxtMember
        {
           NxtMemberId = Guid.NewGuid().ToString(),
            NxtUserName = "hoangvane",
            NxtPassword = "1234756",
            NxtFullName = "Hoàng Văn Em",
            NxtEmail = "hoangvane@gmail.com"
        }
        };
        public IActionResult Index()
        {
            return View(_members);
        }


        public IActionResult GetMember()
        {
            var member = new NxtMember
            {
                NxtMemberId = Guid.NewGuid().ToString(),
                NxtUserName = "AzTV",
                NxtPassword = "password1234",
                NxtFullName = "Nguyễn Xuân Trường",
                NxtEmail = "nimion19@gmail.com"
            };
            ViewBag.Member = member;
            return View();
        }

        public IActionResult GetMembers()
        {
            ViewBag.Members = _members;
            return View();
        }

        [HttpGet]
        public IActionResult Create ()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(NxtMember member)
        {
            if (ModelState.IsValid)
            {
                member.NxtMemberId = Guid.NewGuid().ToString();
                _members.Add(member);
                return RedirectToAction(nameof(Index));
            }
            return View(member);
        }
    }
     
}
