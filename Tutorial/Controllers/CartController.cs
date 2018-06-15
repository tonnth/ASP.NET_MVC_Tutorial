using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tutorial.Models;
using Tutorial.Dao;

namespace Tutorial.Controllers
{
    public class CartController : Controller
    {
            Cart cart = (Cart)Session["cart"];
            Sach sach = SachDAO.getSachCanLay(maSach);
            if (cart.getCartItems().ContainsKey(maSach))
            {
                cart.plusTocart(maSach,new Item(sach,cart.getCartItems()[maSach].getSoLuongBan()),soLuongMua);
            }
            else
            {
                cart.plusTocart(maSach, new Item(sach, soLuongMua), soLuongMua);
            }
            return Redirect("~/Home/index");
	}
}