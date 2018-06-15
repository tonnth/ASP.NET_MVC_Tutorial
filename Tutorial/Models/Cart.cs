﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tutorial.Models
{
    public class Cart
    {
        private Dictionary<int, Item> cartItems;
        public Cart()
        {
            cartItems = new Dictionary<int, Item>();
        }
        public Dictionary<int, Item> getCartItems()
        {
            return cartItems;
        }
        public void setCartItems(Dictionary<int, Item> cartItems)
        {
            this.cartItems = cartItems;
        }
        public void plusTocart(int key, Item item, int soLuongMua)
        {
            bool check = cartItems.ContainsKey(key);
            if (check)
            {
                int soLuongCu = item.getSoLuongBan();
                item.setSoLuongBan(soLuongCu + soLuongMua);
                cartItems[key] = item;
            }
            else
            {
                cartItems[key] = item;
            }
        }
        public int countItem()
        {
            int count = 0;
            count = cartItems.Count();
            return count;
        }
    }
}