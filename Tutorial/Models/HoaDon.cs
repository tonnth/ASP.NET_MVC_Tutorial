using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tutorial.Models
{
    public class HoaDon
    {
        private int maHoaDon;
        private int maKhachHang;
        private DateTime ngayLapHoaDon;
        private int maKhuVucGiaoHang;
        private String diaChiGiaoHang;
        private String tenNguoiNhan;
        private String soDienThoai;
        private int soXuSuDung;
        private int tongTienHoaDon;
        private int phiGiaoHang;
        private String thietBiDatHang;

        public HoaDon()
        {
        }

        public int getMaHoaDon()
        {
            return maHoaDon;
        }

        public void setMaHoaDon(int maHoaDon)
        {
            this.maHoaDon = maHoaDon;
        }

        public int getMaKhachHang()
        {
            return maKhachHang;
        }

        public void setMaKhachHang(int maKhachHang)
        {
            this.maKhachHang = maKhachHang;
        }

        public DateTime getNgayLapHoaDon()
        {
            return ngayLapHoaDon;
        }

        public void setNgayLapHoaDon(DateTime ngayLapHoaDon)
        {
            this.ngayLapHoaDon = ngayLapHoaDon;
        }

        public int getMaKhuVucGiaoHang()
        {
            return maKhuVucGiaoHang;
        }

        public void setMaKhuVucGiaoHang(int maKhuVucGiaoHang)
        {
            this.maKhuVucGiaoHang = maKhuVucGiaoHang;
        }

        public String getDiaChiGiaoHang()
        {
            return diaChiGiaoHang;
        }

        public void setDiaChiGiaoHang(String diaChiGiaoHang)
        {
            this.diaChiGiaoHang = diaChiGiaoHang;
        }

        public String getTenNguoiNhan()
        {
            return tenNguoiNhan;
        }

        public void setTenNguoiNhan(String tenNguoiNhan)
        {
            this.tenNguoiNhan = tenNguoiNhan;
        }

        public String getSoDienThoai()
        {
            return soDienThoai;
        }

        public void setSoDienThoai(String soDienThoai)
        {
            this.soDienThoai = soDienThoai;
        }

        public int getSoXuSuDung()
        {
            return soXuSuDung;
        }

        public void setSoXuSuDung(int soXuSuDung)
        {
            this.soXuSuDung = soXuSuDung;
        }

        public int getTongTienHoaDon()
        {
            return tongTienHoaDon;
        }

        public void setTongTienHoaDon(int tongTienHoaDon)
        {
            this.tongTienHoaDon = tongTienHoaDon;
        }

        public int getPhiGiaoHang()
        {
            return phiGiaoHang;
        }
        public void setPhiGiaoHang(int phiGiaoHang)
        {
            this.phiGiaoHang = phiGiaoHang;
        }
        public void setThietBiDatHang(String thietBi)
        {
            this.thietBiDatHang = thietBi;
        }
        public String getThietBiDatHang()
        {
            return thietBiDatHang;
        }
    }
}