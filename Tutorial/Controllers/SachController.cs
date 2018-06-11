using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
        public ActionResult ChiTiet(String TenSach)
        {
            ViewBag.TenSach = TenSach;
            return View();
        }
      
    }
}