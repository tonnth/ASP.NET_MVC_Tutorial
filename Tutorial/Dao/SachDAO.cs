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
        static int numOfBook = 0;
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
        public static List<Sach> getListSach(int page = 1)
        {
            int numOfBook = 24;
            int row = numOfBook * (page - 1);
            String pagination = " LIMIT " + row+"," + numOfBook;
            String sql = "Select * from Sach where TrangThai <> -1" + pagination;
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
                sach = new Sach(rs);
            }
            rs.Close();
            connection.Close();
            return sach;
        }

        public static int getNumberOfBook()
        {
            String sql = "Select count(*) as NUM from Sach where TrangThai <> -1";
            MySqlConnection connection = DBConnect.getConnection();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            MySqlDataReader rs = cmd.ExecuteReader();
            while (rs.Read())
            {
                numOfBook= rs.GetInt32("NUM");
            }
            rs.Close();
            connection.Close();
            return numOfBook;
        }
        public static void updateLike(int value, int maSach)
        {
            String sql = "Update Sach set YeuThich=" + value + " Where MaSach=" + maSach;
            MySqlConnection connection = DBConnect.getConnection();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}