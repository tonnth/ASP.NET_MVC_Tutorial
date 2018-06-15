using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tutorial.Models
{
    public class KhachHang
    {
        private int maKhachHang;
        private String hoTenKhachHang;
        private String eMail;
        private String matKhau;
        private int tienNo;
        private int loaiKhachHang;
        private int soXuTichLuy;

        public KhachHang()
        {
        }

        public int getMaKhachHang()
        {
            return maKhachHang;
        }

        public void setMaKhachHang(int maKhachHang)
        {
            this.maKhachHang = maKhachHang;
        }

        public String getHoTenKhachHang()
        {
            return hoTenKhachHang;
        }

        public void setHoTenKhachHang(String hoTenKhachHang)
        {
            this.hoTenKhachHang = hoTenKhachHang;
        }

        public String geteMail()
        {
            return eMail;
        }

        public void seteMail(String eMail)
        {
            this.eMail = eMail;
        }

        public String getMatKhau()
        {
            return matKhau;
        }

        public void setMatKhau(String matKhau)
        {
            this.matKhau = matKhau;
        }

        public int getTienNo()
        {
            return tienNo;
        }

        public void setTienNo(int tienNo)
        {
            this.tienNo = tienNo;
        }

        public int getLoaiKhachHang()
        {
            return loaiKhachHang;
        }

        public void setLoaiKhachHang(int loaiKhachHang)
        {
            this.loaiKhachHang = loaiKhachHang;
        }

        public int getSoXuTichLuy()
        {
            return soXuTichLuy;
        }

        public void setSoXuTichLuy(int soXuTichLuy)
        {
            this.soXuTichLuy = soXuTichLuy;
        }
    }
}