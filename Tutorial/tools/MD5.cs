using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;

namespace Tutorial.tools
{ 
    public class MD5
    {
        public static String encryption(String str)
        {
            MD5CryptoServiceProvider MD5Code = new MD5CryptoServiceProvider();
            byte[] chuoiMaHoa = Encoding.UTF8.GetBytes(str);
            chuoiMaHoa = MD5Code.ComputeHash(chuoiMaHoa);
            //Chuyển các ký tự từ mã binary to mã hexa
            StringBuilder sb = new StringBuilder();
            foreach (byte ba in chuoiMaHoa)
            {
                sb.Append(ba.ToString("x2"));//'X2' mã hóa các ký tự trả về đều hoa('x2' mã hóa các ký tự về thường) dùng ToLower để chuyển về ký tự thường
            }
            return sb.ToString();
        }
    }
}