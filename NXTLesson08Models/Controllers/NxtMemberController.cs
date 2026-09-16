using Microsoft.AspNetCore.Mvc;
using NXTLesson08Models.Models;

namespace NXTLesson08Models.Controllers
{
    public class NxtMemberController : Controller
    {
        private static List<NxtMember> _members = new List<NxtMember>()
        {

    new NxtMember
    {
        NxtMemberId = Guid.NewGuid().ToString(),
        NxtUserName = "Nguyenxuantruong ",
        NxtPassword = "Password12345@",
        NxtFullName = "Nguyễn Xuân Trường",
        NxtEmail = "nimion9@gmail.com"
    },
    new NxtMember
    {
        NxtMemberId = Guid.NewGuid().ToString(),
        NxtUserName = "tranthib",
        NxtPassword = "SecurePassword456#",
        NxtFullName = "Tran Thi B",
        NxtEmail = "tranthib@example.com"
    },
    new NxtMember
    {
        NxtMemberId = Guid.NewGuid().ToString(),
        NxtUserName = "levanc",
        NxtPassword = "P@ssword789!",
        NxtFullName = "Le Van C",
        NxtEmail = "levanc@example.com"
    }
        };
        public IActionResult Index()
        {
            return View(_members);
        }


        [HttpGet]
        public IActionResult NxtCreate()
        {
            var member = new NxtMember();
            return View(member);
        }

        [HttpPost]
        public IActionResult NxtCreate(NxtMember nxtMember)
        {
            nxtMember.NxtMemberId = Guid.NewGuid().ToString();
            _members.Add(nxtMember);

            return RedirectToAction("Index");
            //return View(nxtMember);
        }
        [HttpGet]
        public IActionResult NxtEdit(string id)
        {
            var member = _members.Where(x => x.NxtMemberId.Equals(id)).FirstOrDefault();
            return View(member);
        }
        [HttpPost]
        public IActionResult NxtEdit(string id, NxtMember nxtMember)
        {
            //var member = _members.Where(x => x.NxtMemberId.Equals(id)).FirstOrDefault();
            for (int i = 0; i < _members.Count; i++)
            {
                if (_members[i].NxtMemberId == id)
                {
                    _members[i].NxtUserName = nxtMember.NxtUserName;
                    _members[i].NxtPassword = nxtMember.NxtPassword;
                    _members[i].NxtFullName = nxtMember.NxtFullName;
                    _members[i].NxtEmail = nxtMember.NxtEmail;

                    return RedirectToAction("Index");
                }
            }
            return View();
            //return View(nxtMember);
        }

        [HttpGet]
        public IActionResult NxtDetails(string id)
        {
            var member = _members.Where(x => x.NxtMemberId.Equals(id)).FirstOrDefault();
            return View(member);
        }

        [HttpGet]
        public IActionResult NxtDelete(string id)
        {
            var member = _members.Where(x => x.NxtMemberId.Equals(id)).FirstOrDefault();
            return View(member);
        }

        [HttpPost]
        public IActionResult NxtDeleted(string id)
        {
            foreach (var item in _members)
            {
                if (item.NxtMemberId.Equals(id))
                {
                    _members.Remove(item);
                    return RedirectToAction("Index");
                }
            }
            return View("NxtDelete");
        }
    }
}

