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
        public String Index()
        {
            return "Đây là phương thức Index của Controller Sach";
        }
        public String ChiTiet()
        {
            return "Đây là phương thức ChiTiet của Controller Sach";
        }
    }
}