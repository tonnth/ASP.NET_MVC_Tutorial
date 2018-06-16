using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tutorial.Dao;
using Tutorial.Models;
using Tutorial.tools;

namespace Tutorial.Controllers
{
    public class KhachHangController : Controller
    {
        // GET: /KhachHang/
        public ActionResult DangKy()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangKy(FormCollection f)
        {
            String error = "";
            if (string.IsNullOrEmpty(f["username"]))
            {
                error += "Tên không được để trống";
                ViewBag.message1 = "Tên không được để trống";
            }
            if (string.IsNullOrEmpty(f["email"]))
            {
                error += "Email không được để trống";
                ViewBag.message2 = "Email không được để trống";
            }
            if (string.IsNullOrEmpty(f["pass"]))
            {
                error += "Password không được để trống";
                ViewBag.message3 = "Password không được để trống";
            }
            else
            {
                if (!f["re_pass"].Equals(f["pass"]))
                {
                    error += "Mật khẩu xác nhận không khớp";
                    ViewBag.message4 = "Mật khẩu xác nhận không khớp";
                }
            }
            if (string.IsNullOrEmpty(error))
            {
                //Kiểm email người dùng có tồn tại hay chưa
                if (!KhachHangDAO.checkEmail(f["email"].ToString()))
                {
                    //Them khach hang moi
                    KhachHang kh = new KhachHang();
                    kh.setHoTenKhachHang(f["username"]);
                    kh.seteMail(f["email"]);
                    kh.setMatKhau(MD5.encryption(f["pass"]));
                    kh.setTienNo(0);
                    kh.setLoaiKhachHang(0);
                    kh.setSoXuTichLuy(0);
                    KhachHangDAO.insertKhachHang(kh);
                    kh.setMaKhachHang(KhachHangDAO.getMaKhachHang(f["email"]));
                    Session["user"] = kh;
                }
                else
                {
                    ViewBag.error = "Email da ton tai trong he thong";
                }
                if (ViewBag.error == null)
                {
                    return Redirect("~/Home/index");
                }

            }
            return View();
        }
        public ActionResult DangNhap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangNhap(FormCollection f)
        {
            //Kiem tra email va MatKhau co ton tai trong csdl hay chu
            KhachHang kh = null;
            kh = KhachHangDAO.loginKhachHang(f["email"].ToString(), MD5.encryption(f["pass"].ToString()));
            if (kh != null)
            {
                Session["user"] = kh;
                return Redirect("~/Home/index");
            }
            else
            {
                ViewBag.message = "Email hoac mat khau khong ton tai";
            }
            return View();
        }
        public ActionResult thongtinkhachhang()
        {
            return View();
        }
        //Xác nhận mua hàng
        [HttpPost]
        public ActionResult thongtinkhachhang(FormCollection f)
        {
            String error = "";
            Cart cart = (Cart)Session["cart"];
            if (string.IsNullOrEmpty(f["email"]))
            {
                ViewBag.message2 = "Email không được để trống";
                error += "Email không được để trống";
            }
            if (string.IsNullOrEmpty(f["pass"]))
            {
                ViewBag.message3 = "Mật khẩu không được để trống";
                error += "Mật khẩu không được để trống";
            }
            if (error.Equals(""))
            {
                KhachHang khachHang = new KhachHang();
                //New
                if (KhachHangDAO.checkEmail(f["email"]))
                {
                    khachHang = KhachHangDAO.loginKhachHang(f["email"], MD5.encryption(f["pass"]));
                }
                else
                {
                    khachHang = null;
                    error = "Chưa đăng ký khách hàng trên hệ thống";
                }
                //
                if (khachHang != null)
                {
                    Session["user"] = khachHang;
                    return Redirect("~/HoaDon/hoadon");
                }
                else
                {
                    if (error.Equals(""))
                    {
                        error = "Mật khẩu đăng nhập không đúng";
                    }
                }
                if (!error.Equals(""))
                    ViewBag.error = error;
            }
            return View();
        }
    }
}