using Microsoft.AspNetCore.Mvc;
using NXTLesson04Lab.Models;

using System.Net;
using System.Reflection;
using System.Xml.Linq;


namespace NXTLesson04Lab.Controllers

{
    public class NxtAccountController : Controller
    {
        private readonly List<NxtAccount> NxtAccounts = new()
        {
       new NxtAccount
    {
        Id = 1,
        Name = "Shenhe",
        Email = "an.nguyen@example.com",
        Phone = "0901234567",
        Avatar = "/Images/1.jpg",
        Address = "123 Đường Lê Lợi, Quận 1, TP.HCM",
        Bio = "Lập trình viên C# yêu thích công nghệ.",
        Gender = 1, // 1: Nam, 0: Nữ
        Birthday = new DateTime(1995, 5, 15)
    },
    new NxtAccount
    {
        Id = 2,
        Name = "Zongli",
        Email = "bich.tran@example.com",
        Phone = "0912345678",
        Avatar = "/Images/2.jpg" ,
        Address = "45 Phố Huế, Hoàn Kiếm, Hà Nội",
        Bio = "UI/UX Designer. Yêu thích sự tối giản.",
        Gender = 0,
        Birthday = new DateTime(1998, 10, 20)
    },
    new NxtAccount
    {
        Id = 3,
        Name = "Bé Shenhe",
        Email = "nam.le@example.com",
        Phone = "0987654321",
        Avatar = "/Images/3.png",
        Address = "78 Nguyễn Văn Linh, Hải Châu, Đà Nẵng",
        Bio = "Project Manager. Thích du lịch và đọc sách.",
        Gender = 1,
        Birthday = new DateTime(1992, 3, 8)
    },
    new NxtAccount
    {
         Id = 4,
        Name = "Triệu Vô Cực ",
        Email = "vo.cuc@example.com",
        Phone = "0987654021",
        Avatar = "/Images/4.jpg",
        Address = "78 Nguyễn Văn Linh, Hải Châu, Đà Nẵng",
        Bio = "Project Manager. Thích du lịch và đọc sách.",
        Gender = 1,
        Birthday = new DateTime(1990, 3, 8)
    },
     new NxtAccount
    {
         Id = 5,
        Name = " Vô Cực Ma Tôn ",
        Email = "vo.cuc@example.com",
        Phone = "0987654021",
        Avatar = "/Images/5.jpg",
        Address = "78 Nguyễn Văn Linh, Hải Châu, Đà Nẵng",
        Bio = "Project Manager. Thích du lịch và đọc sách.",
        Gender = 1,
        Birthday = new DateTime(1999, 3, 8)
    }
        };
        public IActionResult NxtIndex()
        {
            ViewBag.NxtAccounts = NxtAccounts;
            return View();
        }

        [Route("ho-so-cua-toi",Name ="NxtProfile")]
        public IActionResult NxtProfile(int? id)
        {
            NxtAccount NxtAccount = new NxtAccount 
            {
                Id = 1,
                Name = "Shenhe",
                Email = "an.nguyen@example.com",
                Phone = "0901234567",
                Avatar = "/Images/1.jpg",
                Address = "123 Đường Lê Lợi, Quận 1, TP.HCM",
                Bio = "Lập trình viên C# yêu thích công nghệ.",
                Gender = 1, // 1: Nam, 0: Nữ
                Birthday = new DateTime(1995, 5, 15)
            };
            if (id != null)
             NxtAccount = NxtAccounts.FirstOrDefault(x  => x.Id == id);
            ViewBag.NxtAccount = NxtAccount;
            return View();
        }
    }
}
