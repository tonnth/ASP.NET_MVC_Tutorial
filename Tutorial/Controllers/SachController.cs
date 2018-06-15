using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tutorial.Dao;
using Tutorial.Models;

namespace Tutorial.Controllers
{
    public class SachController : Controller
    {
        // GET: Sach
        public ActionResult Index()
        {
            ViewBag.listSach = new List<String> { "Conan", "Doraemon", "Pokemon", "Dragon Balls", "One Piece" };
            return View();
        }
        public ActionResult ChiTiet(int maSach)
        {
            Sach sach = SachDAO.getSach(maSach);
            ViewBag.sach = SachDAO.getSach(maSach);
            return View();
        }

        public PartialViewResult ListSach(int page = 1)
        {
            List<Sach> listSach = new List<Sach>();
            ViewBag.currentPage = page;
            ViewBag.listSach = SachDAO.getListSach(page);
            ViewBag.numOfBook = SachDAO.getNumberOfBook();
            return PartialView();
        }

        [HttpPost]
        public ActionResult updateLike(int value, int maSach)
        {
            System.Diagnostics.Debug.WriteLine(value + ' ' + maSach);
            SachDAO.updateLike(value, maSach);
            return Json("chamara", JsonRequestBehavior.AllowGet);
        }
    }
}