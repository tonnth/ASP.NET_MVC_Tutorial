using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tutorial.Connect;
using Tutorial.Models;

namespace Tutorial.Dao
{
    public class SachDAO
    {
        public static List<Sach> getSachFromDB(String sql)
        {
            MySqlConnection connection = DBConnect.getConnection();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            List<Sach> list = new List<Sach>();
            MySqlDataReader rs = cmd.ExecuteReader();
            while (rs.Read())
            {
                list.Add(new Sach(rs));
            }
            rs.Close();
            connection.Close();
            return list;
        }
        public static List<Sach> getListSach()
        {
            String sql = "Select * from Sach where TrangThai <> -1";
            return getSachFromDB(sql);
        }
        public static Sach getSach(int maSach)
        {
            MySqlConnection connection = DBConnect.getConnection();
            connection.Open();
            String sql = "Select * from Sach where MaSach=?MaSach";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("?MaSach", maSach);
            MySqlDataReader rs = cmd.ExecuteReader();
            Sach sach = null; ;
            while (rs.Read())
            {
                sach = new Sach();
                sach.setMaSach(rs.GetInt32("MaSach"));
                sach.setTenSach(rs.GetString("TenSach"));
                sach.setTacGia(rs.GetString("TacGia"));
                sach.setHinhAnh(rs.GetString("HinhAnh"));
                sach.setMoTa(rs.GetString("MoTa"));
                sach.setSoLuongTon(rs.GetInt32("SoLuongTon"));
                sach.setGiaBan(rs.GetInt32("GiaBan"));
                sach.setTrangThai(rs.GetInt32("TrangThai"));
                sach.setKhuyenMai(rs.GetInt32("KhuyenMai"));
                sach.setMaTheLoai(rs.GetInt32("MaTheLoai"));
            }
            rs.Close();
            connection.Close();
            return sach;
        }
    }
}