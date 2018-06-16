using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tutorial.Models
{
    public class Item
    {
        private Sach sach;
        private int soLuongBan;
        public Item()
        {

        }
        public Item(Sach sach, int soLuongBan)
        {
            this.sach = sach;
            this.soLuongBan = soLuongBan;
        }
        public Sach getSach()
        {
            return sach;
        }
        public void setSach(Sach sach)
        {
            this.sach = sach;
        }
        public int getSoLuongBan()
        {
            return soLuongBan;
        }
        public void setSoLuongBan(int soLuongBan)
        {
            this.soLuongBan = soLuongBan;
        }
    }
}