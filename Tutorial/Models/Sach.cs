using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tutorial.Models
{
    public class Sach
    {
        private int maSach;
        private String tenSach;
        private String tacGia;
        private String hinhAnh;
        private String moTa;
        private int soLuongTon;
        private int giaBan;
        private int trangThai;
        private int khuyenMai;
        private int maTheLoai;

        public int getMaTheLoai()
        {
            return maTheLoai;
        }

        public void setMaTheLoai(int maTheLoai)
        {
            this.maTheLoai = maTheLoai;
        }
        public Sach(MySqlDataReader rs)
        {
            maSach = rs.GetInt32("MaSach");
            tenSach = rs.GetString("TenSach");
            tacGia = rs.GetString("TacGia");
            hinhAnh = rs.GetString("HinhAnh");
            moTa = rs.GetString("MoTa");
            soLuongTon = rs.GetInt32("SoLuongTon");
            giaBan = rs.GetInt32("GiaBan");
            trangThai = rs.GetInt32("TrangThai");
            khuyenMai = rs.GetInt32("KhuyenMai");
            maTheLoai = rs.GetInt32("MaTheLoai");
        }
        public Sach()
        {
        }

        public int getMaSach()
        {
            return maSach;
        }

        public void setMaSach(int maSach)
        {
            this.maSach = maSach;
        }

        public String getTenSach()
        {
            return tenSach;
        }

        public void setTenSach(String tenSach)
        {
            this.tenSach = tenSach;
        }

        public String getTacGia()
        {
            return tacGia;
        }

        public void setTacGia(String tacGia)
        {
            this.tacGia = tacGia;
        }

        public String getHinhAnh()
        {
            return hinhAnh;
        }

        public void setHinhAnh(String hinhAnh)
        {
            this.hinhAnh = hinhAnh;
        }

        public String getMoTa()
        {
            return moTa;
        }

        public void setMoTa(String moTa)
        {
            this.moTa = moTa;
        }

        public int getSoLuongTon()
        {
            return soLuongTon;
        }

        public void setSoLuongTon(int soLuongTon)
        {
            this.soLuongTon = soLuongTon;
        }

        public int getGiaBan()
        {
            return giaBan;
        }

        public void setGiaBan(int giaBan)
        {
            this.giaBan = giaBan;
        }

        public int getTrangThai()
        {
            return trangThai;
        }

        public void setTrangThai(int trangThai)
        {
            this.trangThai = trangThai;
        }

        public int getKhuyenMai()
        {
            return khuyenMai;
        }

        public void setKhuyenMai(int khuyenMai)
        {
            this.khuyenMai = khuyenMai;
        }
    }
}