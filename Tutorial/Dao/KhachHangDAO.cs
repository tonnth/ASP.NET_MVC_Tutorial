﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using Tutorial.Connect;
using Tutorial.Models;

namespace Tutorial.Dao
{
    public class KhachHangDAO
    {
        //Check email 
        public static bool checkEmail(String email)
        {
            MySqlConnection connection = DBConnect.getConnection();
            connection.Open();
            String sql = "Select * from KhachHang where Email='" + email + "'";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            MySqlDataReader rs = cmd.ExecuteReader();
            while (rs.Read())
            {
                rs.Close();
                connection.Close();
                return true;
            }
            return false;
        }
        //Lấy mã khách theo email
        public static int getMaKhachHang(String email)
        {
            int maKhachHang = 0;
            MySqlConnection connection = DBConnect.getConnection();
            connection.Open();
            String sql = "Select MaKhachHang from KhachHang where Email='" + email + "'";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            MySqlDataReader rs = cmd.ExecuteReader();
            while (rs.Read())
            {
                maKhachHang = rs.GetInt32("MaKhachHang");
            }
            rs.Close();
            connection.Close();
            return maKhachHang;
        }
        //Add khach hang
        public static bool insertKhachHang(KhachHang u)
        {
            MySqlConnection connection = DBConnect.getConnection();
            connection.Open();
            String sql = "Insert into KhachHang(HoTenKhachHang,Email,MatKhau,TienNo,LoaiKhachHang,SoXuTichLuy) values(?HoTenKhachHang,?Email,?MatKhau,?TienNo,?LoaiKhachHang,?SoXuTichLuy)";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("?HoTenKhachHang", u.getHoTenKhachHang());
            cmd.Parameters.AddWithValue("?Email", u.geteMail());
            cmd.Parameters.AddWithValue("?MatKhau", u.getMatKhau());
            cmd.Parameters.AddWithValue("?TienNo", u.getTienNo());
            cmd.Parameters.AddWithValue("?LoaiKhachHang", u.getLoaiKhachHang());
            cmd.Parameters.AddWithValue("?SoXuTichLuy", u.getSoXuTichLuy());
            cmd.ExecuteNonQuery();
            connection.Close();
            return true;
        }
        public static KhachHang loginKhachHang(String email, String matKhau)
        {
            KhachHang kh = null;
            MySqlConnection connection = DBConnect.getConnection();
            connection.Open();
            String sql = "Select * from KhachHang where Email=?Email and MatKhau=?MatKhau";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("?Email", email);
            cmd.Parameters.AddWithValue("?MatKhau", matKhau);
            MySqlDataReader rs = cmd.ExecuteReader();
            while (rs.Read())
            {
                kh = new KhachHang();
                kh.setMaKhachHang(rs.GetInt32("MaKhachHang"));
                kh.setHoTenKhachHang(rs.GetString("HoTenKhachHang"));
                kh.seteMail(rs.GetString("Email"));
                kh.setMatKhau(rs.GetString("MatKhau"));
                kh.setTienNo(rs.GetInt32("TienNo"));
                kh.setLoaiKhachHang(rs.GetInt32("LoaiKhachHang"));
                kh.setSoXuTichLuy(rs.GetInt32("SoXuTichLuy"));
            }
            rs.Close();
            connection.Close();
            return kh;
        }
        public static bool capNhatKhachHang(int maKhachHang, int tienNo, int soXuTichLuy)
        {
            MySqlConnection connection = DBConnect.getConnection();
            connection.Open();
            String sql = "Update KhachHang set TienNo=?TienNo, SoXuTichLuy=?SoXuTichLuy where MaKhachHang=?MaKhachHang";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("?TienNo", tienNo);
            cmd.Parameters.AddWithValue("?SoXuTichLuy", soXuTichLuy);
            cmd.Parameters.AddWithValue("?MaKhachHang", maKhachHang);
            cmd.ExecuteNonQuery();
            connection.Close();
            return true;
        }
    }
}