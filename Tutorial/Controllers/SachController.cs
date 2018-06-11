﻿using System;
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
        public PartialViewResult ListSach()
        {
            List<Sach> listSach = new List<Sach>();
            ViewBag.listSach = SachDAO.getListSach();
            return PartialView();
        }

    }
}