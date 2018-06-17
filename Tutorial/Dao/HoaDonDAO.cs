using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tutorial.Models;
using MySql.Data.MySqlClient;
using Tutorial.Connect;

namespace Tutorial.Dao
{
    public class HoaDonDAO
    {
        public static bool insertHoaDon(HoaDon hoaDon)
        {
            MySqlConnection connection = DBConnect.getConnection();
            connection.Open();
            String sql = "Insert into HoaDon values(?MaHoaDon,?NgayLapHoaDon,?MaKhachHang,?KhuVuc,?DiaChi,?TenNguoiNhan,?SDT,?SoXu,?TongTien,?Phi,?ThietBi)";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("?MaHoaDon", hoaDon.getMaHoaDon());
            cmd.Parameters.AddWithValue("?NgayLapHoaDon", hoaDon.getNgayLapHoaDon());
            cmd.Parameters.AddWithValue("?MaKhachHang", hoaDon.getMaKhachHang());
            cmd.Parameters.AddWithValue("?KhuVuc", hoaDon.getMaKhuVucGiaoHang());
            cmd.Parameters.AddWithValue("?DiaChi", hoaDon.getDiaChiGiaoHang());
            cmd.Parameters.AddWithValue("?TenNguoiNhan", hoaDon.getTenNguoiNhan());
            cmd.Parameters.AddWithValue("?SDT", hoaDon.getSoDienThoai());
            cmd.Parameters.AddWithValue("?SoXu", hoaDon.getSoXuSuDung());
            cmd.Parameters.AddWithValue("?TongTien", hoaDon.getTongTienHoaDon());
            cmd.Parameters.AddWithValue("?Phi", hoaDon.getPhiGiaoHang());
            cmd.Parameters.AddWithValue("?ThietBi", hoaDon.getThietBiDatHang());
            cmd.ExecuteNonQuery();
            connection.Close();
            return true;
        }
        //Lấy tổng số lượng hóa đơn trong csdl
        public static int getSoLuong()
        {
            int soLuong = 0;
            MySqlConnection connection = DBConnect.getConnection();
            connection.Open();
            String sql = "Select count(*) as SoLuong from HoaDon";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            MySqlDataReader rs = cmd.ExecuteReader();
            while (rs.Read())
            {
                soLuong = rs.GetInt32("SoLuong");
            }
            rs.Close();
            connection.Close();
            return soLuong;
        }
    }
}