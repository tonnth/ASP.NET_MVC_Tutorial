using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tutorial.Models
{
    public class ChiTietHoaDon
    {
        private int maChiTietHoaDon;
        private int maHoaDon;
        private int maSach;
        private int soLuongBan;
        private int giaBanCu;
        private int khuyenMaiCu;
        public ChiTietHoaDon()
        {
        }

        public ChiTietHoaDon(int maChiTietHoaDon, int maHoaDon, int maSach, int soLuongBan, int giaBanCu, int khuyenMaiCu)
        {
            this.maChiTietHoaDon = maChiTietHoaDon;
            this.maHoaDon = maHoaDon;
            this.maSach = maSach;
            this.soLuongBan = soLuongBan;
            this.giaBanCu = giaBanCu;
            this.khuyenMaiCu = khuyenMaiCu;
        }

        public int getMaChiTietHoaDon()
        {
            return maChiTietHoaDon;
        }

        public void setMaChiTietHoaDon(int maChiTietHoaDon)
        {
            this.maChiTietHoaDon = maChiTietHoaDon;
        }

        public int getMaHoaDon()
        {
            return maHoaDon;
        }

        public void setMaHoaDon(int maHoaDon)
        {
            this.maHoaDon = maHoaDon;
        }

        public int getMaSach()
        {
            return maSach;
        }

        public void setMaSach(int maSach)
        {
            this.maSach = maSach;
        }

        public int getSoLuongBan()
        {
            return soLuongBan;
        }

        public void setSoLuongBan(int soLuongBan)
        {
            this.soLuongBan = soLuongBan;
        }
        public int getGiaBanCu()
        {
            return giaBanCu;
        }
        public void setGiaBanCu(int giaBanCu)
        {
            this.giaBanCu = giaBanCu;
        }
        public int getKhuyenMaiCu()
        {
            return khuyenMaiCu;
        }
        public void setKhuyenMaiCu(int khuyenMaiCu)
        {
            this.khuyenMaiCu = khuyenMaiCu;
        }
    }
}