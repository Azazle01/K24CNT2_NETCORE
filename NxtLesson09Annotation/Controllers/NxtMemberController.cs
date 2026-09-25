using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NxtLesson09Annotation.Models.DataModels;
using NxtLesson09Annotation.Models.DataViewModels;
namespace NxtLesson09Annotation.Controllers
{
    public class NxtMemberController : Controller
    {
        private static List<NxtMember> _nxtMembers = new List<NxtMember>();
        // GET: NxtMemberController
        public ActionResult Index()
        {
            return View();
        }

        // GET: NxtMemberController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NxtMemberController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NxtMemberController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: NxtMemberController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NxtMemberController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: NxtMemberController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NxtMemberController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
